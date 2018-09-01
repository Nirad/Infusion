#load "CraftMenu.csx"

public static class TinkeringMenu
{
    public static readonly CraftProduct CopperWire = new CraftProduct(Specs.CopperWire, new CraftResource(Specs.CopperIngot, 1), "Parts", "copper wire");
}

public static class Tinkering
{
    public static ushort BatchSize { get; set; } = 75;

    public static void Produce(CraftProduct product)
    {
        var tool = CraftProducer.AskForItem(Specs.TinkeringTools);
        
        var producer = new CraftProducer(product);
        producer.BatchSize = BatchSize;
        producer.StartCycle = () => UO.Use(tool);
        
        producer.Produce();
    }
}

UO.RegisterCommand("tinkering-wire", () => Tinkering.Produce(TinkeringMenu.CopperWire));
