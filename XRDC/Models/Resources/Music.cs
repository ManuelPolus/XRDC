namespace XRDC.Models.Resources
{
    public class Music : Resource
    {
        public override int Id { get; set; }

        public override string Name { get; set; }

        //true : ON, false = OFF
        public bool OnOff { get; set; }

        public bool Playing { get; set; }

        public string CurrentlyPlayingSong { get; set; }


        public bool Switch()
        {
            return OnOff = OnOff ? false : true;
        }

        public bool PlayPause()
        {
            return Playing = Playing ? false : true;
        }


    }
}
