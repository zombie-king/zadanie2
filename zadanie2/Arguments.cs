using CommandLine;

namespace zadanie2
{
    class Arguments
    {
        [Option('n', longName:"factorial", Required = true, HelpText = "Liczba naturalna")]
        public ulong Number { get; set; }
    }
}
