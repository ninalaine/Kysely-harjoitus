namespace Kysely
{
    internal class Kysymys
    {
        //propertyt
        public string Kys { get; set; }
        public bool Vast { get; set; }

        //constructori
        public Kysymys (string kys, bool vast)
        {
            Kys = kys;
            Vast = vast;
        }
    }
}
