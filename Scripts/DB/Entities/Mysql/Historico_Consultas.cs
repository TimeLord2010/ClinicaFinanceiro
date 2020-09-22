﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;
using MySql.Data.MySqlClient;
using DB;
using Financeiro.DB.Entities.Sqlite;
using Financeiro.DB.Entities.Enums;

namespace WPFClinica.Scripts.DB {

    public class Historico_Consultas {

        public Historico_Consultas (MySqlH mySqlH) {
            Handler = mySqlH;
        }

        MySqlH Handler { get; }

        public const string Name = nameof(Historico_Consultas);

        public int ID { get; private set; }
        public string Funcionario { get; set; }
        public string Paciente { get; set; }
        public string Profissao { get; set; }
        public DateTime RealizadoEm { get; set; }
        public DateTime? PagoEm { get; set; }
        public string Especializacao { get; set; }
        public bool Retorno { get; set; }
        public double Pago { get; set; }
        public bool was_uploaded { get; set; }
        public List<(PaymentMethods, double)> PaymentMethod = new List<(PaymentMethods, double)>();

        public void GetConsultasByRealizadoEm (DateTime begin, DateTime end, Action<Historico_Consultas> action) {
            Handler.QueryRLoop($"call GetConsultasByRealizadoEm(@begin, @end)", (r) => {
                action(Get(r));
            }, ("@begin", begin), ("@end", end));
        }

        public List<(PaymentMethods, double)> GetPayment (int ID) {
            var list = new List<(PaymentMethods, double)>();
            Handler.QueryRLoop($"select pagamento, valor from consultas_formapagamento where Consulta = {ID};", (re) => {
                list.Add((re.GetInt32(0) switch
                {
                    1 => PaymentMethods.Dinheiro,
                    2 => PaymentMethods.Credito,
                    3 => PaymentMethods.Debito,
                    _ => throw new Exception($"Invalid Payment method.")
                }, re.GetDouble(1)));
            });
            return list;
        }

        Historico_Consultas Get (MysqlReader r) {
            return new Historico_Consultas(Handler) {
                ID = r.GetInt32(0),
                Funcionario = r.GetString(1),
                Paciente = r.GetString(2),
                Profissao = r.GetString(3),
                RealizadoEm = r.GetDateTime(4),
                PagoEm = r.GetNullDateTime(5),
                Especializacao = r.GetString(6),
                Retorno = r.GetBool(7),
                Pago = r.GetDouble(8),
                PaymentMethod = GetPayment(r.GetInt32(0))
            };
        }

        //public void Insert(string paciente, DateTime realizacao, double pago) {
        //    SqlH.NonQuery($"insert into {Name} (Paciente, RealizadoEm, PagoEm, Retorno, Pago) values (@pac, @rea, @rea, @ret, @pag);",
        //        ("@pac", paciente),
        //        ("@ret", false),
        //        ("@rea", realizacao),
        //        ("@pag", pago));
        //    });
        //}

        //public static void Insert(string funcionario, string paciente, Profissao profissao, DateTime dateTime) {
        //    NonQuery($"Erro ao inserir consulta. ({nameof(ErrorCodes.DB0021)})", (c) => {
        //        c.CommandText = $"insert into {Name} values (null, @f, @paciente, @profissao, @dateTime, @r, @o)";
        //        c.Parameters.AddWithValue("@f", funcionario);
        //        c.Parameters.AddWithValue("@paciente", paciente);
        //        c.Parameters.AddWithValue("@profissao", profissao.ToString());
        //        c.Parameters.AddWithValue("@dateTime", dateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
        //        c.Parameters.AddWithValue("@r", false);
        //        return c;
        //    });
        //}

        //public static void Insert(string paciente, string especializacao, DateTime dt, string retorno) {
        //    NonQuery($"Erro ao inserir consulta. ({nameof(ErrorCodes.DB0022)})", (c) => {
        //        c.CommandText = $"Insert into {Name} values (null, null, @pa, @es, @dt, @r, '');";
        //        c.Parameters.AddWithValue("@pa", paciente);
        //        c.Parameters.AddWithValue("@pr", especializacao);
        //        c.Parameters.AddWithValue("@dt", dt.ToString("yyyy-MM-dd"));
        //        c.Parameters.AddWithValue("@r", retorno);
        //        return c;
        //    });
        //}

        //public static void FullInsert(string funcionario, string paciente, Profissao profissao, DateTime dateTime) {
        //    Insert(funcionario, paciente, profissao, dateTime);
        //    var r = Select(paciente, dateTime.AddMinutes(-1), dateTime.AddMinutes(1));
        //    if (r.Count == 0) {
        //        MessageBox.Show("Falha ao obter identificador de historico inserido. A consulta precisa ser adicionada manualmente ao registro de 'à receber' e 'à pagar'");
        //    } else {
        //        var row = r[r.Count - 1];
        //        var le = ListaEspera.Select_Paciente(paciente);
        //        var esp = ListaEspera_Especializacao.Select(le.Senha);
        //        if (esp != null) {
        //            Update_Especialização(row.ID, esp.Especializacao);
        //        }
        //    }
        //}

        //public static void Delete(int id) {
        //    NonQuery($"Erro ao deletar consulta. ({ErrorCodes.DB0023})", (c) => {
        //        c.CommandText = $"delete from {Name} where {nameof(ID)} = @id;";
        //        c.Parameters.AddWithValue("@id", id);
        //        return c;
        //    });
        //}

        //public static void Update_Funcionario(int id, string funcionario) {
        //    NonQuery($"Erro ao atualizar de consulta. ({ErrorCodes.DB0024})", (c) => {
        //        c.CommandText = $"update {Name} set {nameof(Funcionario)} = @fun, {nameof(RealizadoEm)} = @dt where {nameof(ID)} = {id};";
        //        c.Parameters.AddWithValue("@fun", funcionario);
        //        c.Parameters.AddWithValue("@dt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        //        return c;
        //    });
        //}

        //public static void Update_Profissão(int id, Profissao profissao) {
        //    NonQuery($"Erro ao atualizar consulta. ({ErrorCodes.DB0025})", (c) => {
        //        c.CommandText = $"update {Name} set {nameof(Profissao)} = @p where {nameof(ID)} = @id;";
        //        c.Parameters.AddWithValue("@id", id);
        //        c.Parameters.AddWithValue("@p", profissao.ToString());
        //        return c;
        //    });
        //}

        //public static void Update_Especialização(int id, string especializacao) {
        //    NonQuery($"Erro ao atualizar consulta. ({ErrorCodes.DB0026})", (c) => {
        //        c.CommandText = $"update {Name} set {nameof(Especializacao)} = @esp where {nameof(ID)} = @id;";
        //        c.Parameters.AddWithValue("@id", id);
        //        c.Parameters.AddWithValue("@esp", especializacao);
        //        return c;
        //    });
        //}

        //public static void Update_PagoEm(int id, DateTime dateTime) {
        //    NonQuery($"Erro ao atualizar consulta. ({ErrorCodes.DB0027})", (c) => {
        //        c.CommandText = $"update {Name} set {nameof(PagoEm)} = @pag where {nameof(ID)} = @id;";
        //        c.Parameters.AddWithValue("@pag", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
        //        c.Parameters.AddWithValue("@id", id);
        //        return c;
        //    });
        //}

        //public static void Update_PagoEm(int id) {
        //    NonQuery($"Erro ao atualizar consulta. ({ErrorCodes.DB0028})", (c) => {
        //        c.CommandText = $"update {Name} set {nameof(PagoEm)} = null where {nameof(ID)} = @id;";
        //        c.Parameters.AddWithValue("@id", id);
        //        return c;
        //    });
        //}

        //public static Historico_Consultas Select(int id) {
        //    var c = new MySqlCommand();
        //    c.CommandText =
        //    $"select * from {Name} where {nameof(ID)} = @id;";
        //    c.Parameters.AddWithValue("@id", id);
        //    Historico_Consultas h = null;
        //    QueryRLoop($"Erro ao obter histórico de consulta. ({ErrorCodes.DB0015})", c, (r) => {
        //        h = new Historico_Consultas();
        //        h.ID = id;
        //        h.Funcionario = r.GetString(1);
        //        h.Paciente = r.GetString(2);
        //        h.Profissao = r.GetString(3);
        //        h.RealizadoEm = r.GetMySqlDateTime(4).GetDateTime();
        //        h.PagoEm = r.IsDBNull(5) ? (DateTime?)null : r.GetMySqlDateTime(5).GetDateTime();
        //        h.Especializacao = r.GetString(7);
        //        h.Retorno = r.GetBoolean(8);
        //        h.Pago = r.GetDouble(9);
        //    });
        //    return h;
        //}

        //public static List<_HistoricoConsulta> Select(string cpf_paciente, DateTime begin, DateTime end) {
        //    var c = new MySqlCommand();
        //    c.CommandText =
        //    $"select " +
        //    $"  a.{nameof(ID)}, " +
        //    $"  a.{nameof(Paciente)}, " +
        //    $"  b.{nameof(Pessoas.Nome)}, " +
        //    $"  a.{nameof(Funcionario)}, " +
        //    $"  c.{nameof(Pessoas.Nome)}, " +
        //    $"  a.{nameof(RealizadoEm)}, " +
        //    $"  a.{nameof(Profissao)}  " +
        //    $"from {Name} as a " +
        //    $"inner join {Pessoas.p.TableName} as b on a.{nameof(Paciente)} = b.{nameof(Pessoas.CPF)} " +
        //    $"left join {Pessoas.p.TableName} as c on a.{nameof(Funcionario)} = c.{nameof(Pessoas.CPF)} " +
        //    $"where " +
        //    $"  b.{nameof(Pessoas.CPF)} = @p and " +
        //    $"  (a.{nameof(RealizadoEm)} between @begin and @end);";
        //    c.Parameters.AddWithValue("@p", cpf_paciente);
        //    c.Parameters.AddWithValue("@begin", begin.ToString("yyyy-MM-dd HH:mm:ss"));
        //    c.Parameters.AddWithValue("@end", end.ToString("yyyy-MM-dd HH:mm:ss"));
        //    var lista = new List<_HistoricoConsulta>();
        //    QueryRLoop($"Erro ao obter histório de consultas. ({ErrorCodes.DB0016})", c, (r) => {
        //        var hc = new _HistoricoConsulta() {
        //            ID = r.GetInt32(0),
        //            CPF_Paciente = r.GetString(1),
        //            Nome_Paciente = r.GetString(2),
        //            CPF_Funcionario = r.IsDBNull(3) ? null : r.GetString(3),
        //            Nome_Funcionario = r.IsDBNull(4) ? null : r.GetString(4),
        //            Profissão = r.IsDBNull(6) ? null : r.GetString(6)
        //        };
        //        if (!r.IsDBNull(5)) hc.RealizadoEm = r.GetMySqlDateTime(5).GetDateTime();
        //        lista.Add(hc);
        //    }, Create, true);
        //    return lista;
        //}

        //public static List<_HistoricoConsulta> Select2(string nome_paciente, string nome_funcionario, DateTime begin, DateTime end, bool retorno, bool pago, bool recebido) {
        //    var lista = new List<_HistoricoConsulta>();
        //    var c = new MySqlCommand();
        //    c.CommandText =
        //    $"select " +
        //    $"  a.{nameof(ID)}, " +
        //    $"  a.{nameof(Paciente)}, " +
        //    $"  b.{nameof(Pessoas.Nome)}, " +
        //    $"  a.{nameof(Funcionario)}, " +
        //    $"  c.{nameof(Pessoas.Nome)}, " +
        //    $"  a.{nameof(RealizadoEm)}, " +
        //    $"  a.{nameof(Profissao)}, " +
        //    $"  a.{nameof(Especializacao)}," +
        //    $"  a.{nameof(Retorno)}," +
        //    $"  a.{nameof(PagoEm)}," +
        //    $"  d.{nameof(ConsultasRecebidas.RecebidaEm)}," +
        //    $"  a.{nameof(Pago)} " +
        //    $"from {Name} as a " +
        //    $"inner join {Pessoas.p.TableName} as b on a.{nameof(Paciente)} = b.{nameof(Pessoas.CPF)} " +
        //    $"left join {Pessoas.p.TableName} as c on a.{nameof(Funcionario)} = c.{nameof(Pessoas.CPF)} " +
        //    $"left join {ConsultasRecebidas.Name} as d on a.{nameof(ID)} = d.{nameof(ConsultasRecebidas.Consulta)} " +
        //    $"where " +
        //    $"  b.{nameof(Pessoas.Nome)} like concat(@nome_p, '%') and " +
        //    $"  (c.{nameof(Pessoas.Nome)} like concat(@nome_f, '%') or c.{nameof(Pessoas.Nome)} is null) and " +
        //    $"  (a.{nameof(RealizadoEm)} between @begin and @end) and " +
        //    $"  a.{nameof(Retorno)} = @r and " +
        //    $"  (a.{nameof(PagoEm)} is {(pago ? "not" : "")} null) and " +
        //    $"  (d.{nameof(ConsultasRecebidas.RecebidaEm)} is {(recebido ? "not" : "")} null) " +
        //    $"limit 500;";
        //    c.Parameters.AddWithValue("@nome_p", nome_paciente);
        //    c.Parameters.AddWithValue("@nome_f", nome_funcionario);
        //    c.Parameters.AddWithValue("@begin", begin.ToString("yyyy-MM-dd HH:mm:ss"));
        //    c.Parameters.AddWithValue("@end", end.ToString("yyyy-MM-dd HH:mm:ss"));
        //    c.Parameters.AddWithValue("@r", retorno);
        //    QueryRLoop($"Erro ao obter histório de consultas. ({ErrorCodes.DB0017})", c, (r) => {
        //        lista.Add(new _HistoricoConsulta() {
        //            ID = r.GetInt32(0),
        //            CPF_Paciente = r.GetString(1),
        //            Nome_Paciente = r.GetString(2),
        //            CPF_Funcionario = r.IsDBNull(3)? null : r.GetString(3),
        //            Nome_Funcionario = r.IsDBNull(4)? null : r.GetString(4),
        //            RealizadoEm = r.GetMySqlDateTime(5).GetDateTime(),
        //            Profissão = r.IsDBNull(6)? null : r.GetString(6),
        //            Especializacao = r.IsDBNull(7) ? null : r.GetString(7),
        //            Retorno = r.GetBoolean(8),
        //            PagoEm = r.IsDBNull(9) ? (DateTime?)null : r.GetMySqlDateTime(9).GetDateTime(),
        //            RecebidoEm = r.IsDBNull(10) ? (DateTime?)null : r.GetMySqlDateTime(10).GetDateTime(),
        //            Valor = r.GetDouble(11)
        //        });
        //    }, Create, true);
        //    return lista;
        //}

        //public static List<Historico_Consultas> Select_Especialzação(string nome_paciente, string especialização) {
        //    var c = new MySqlCommand();
        //    c.CommandText =
        //        $"select a.* " +
        //        $"from {Name} as a " +
        //        $"inner join {Pessoas.p.TableName} as c on a.{nameof(Paciente)} = c.{nameof(Pessoas.CPF)} " +
        //        $"where c.{nameof(Pessoas.Nome)} like concat(@np, '%') and {nameof(Especializacao)} = @e " +
        //        $"limit 500;";
        //    c.Parameters.AddWithValue("@np", nome_paciente);
        //    c.Parameters.AddWithValue("@e", especialização);
        //    var lista = new List<Historico_Consultas>();
        //    QueryR($"Erro ao obter histórico de consultas. ({ErrorCodes.DB0018})", c, (r) => {
        //        while (r.Read()) {
        //            var a = new Historico_Consultas() {
        //                ID = r.GetInt32(0),
        //                Funcionario = r.IsDBNull(1) ? null : r.GetString(1),
        //                Paciente = r.IsDBNull(2) ? null : r.GetString(2),
        //                RealizadoEm = r.GetMySqlDateTime(4).GetDateTime(),
        //                Retorno = r.GetBoolean(7),
        //            };
        //            if (!r.IsDBNull(3)) {
        //                a.Profissao = r.GetString(3);
        //            }
        //            lista.Add(a);
        //        }
        //    });
        //    return lista;
        //}

        //private static void Create(Exception ex) {
        //    if (ex.Message.Contains("doesn't exist")) {
        //        CreateTable();
        //        //ConsultasRecebidas.CreateTable();
        //    }
        //}

        public static explicit operator string(Historico_Consultas h) {
            string a = "";
            a += $"ID: {h.ID}\n";
            a += $"Funcionário: {h.Funcionario}\n";
            a += $"Paciente: {h.Paciente}\n";
            a += $"Profissão: {h.Profissao}\n";
            a += $"Realizado: {h.RealizadoEm:dd-MM-yyyy HH:mm:ss}\n";
            a += $"PagoEm: {(h.PagoEm.HasValue ? h.PagoEm.Value.ToString("dd-MM-yyyy HH:mm:ss") : "[null]")}\n";
            a += $"Especialização: {h.Especializacao}\n";
            a += $"Retorno: {h.Retorno}\n";
            a += $"Pago: {h.Pago}\n";
            return a;
        }

    }

}
