namespace FishWellSpace
{
    public class FishWellConfig
    {
        public bool InstantConstruction { get; set; } = false;
        public bool FishWellsWorkSlower { get; set; } = false;
        public double SlowSpawnSpeed { get; set; } = 0.65;
        public double SlowProduceSpeed { get; set; } = 0.65;
        public int WellPopulationCap { get; set; } = 10;
    }
}