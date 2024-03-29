using System.Globalization;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite1 = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva1 = new(diasReservados: 5);
reserva1.CadastrarSuite(suite1);
reserva1.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
Console.WriteLine($"Tipo de suíte: {suite1.TipoSuite}");
Console.WriteLine($"Valor diária: {reserva1.CalcularValorDiaria().ToString("C2", CultureInfo.CurrentCulture)}");