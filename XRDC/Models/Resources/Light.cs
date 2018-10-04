namespace XRDC.Models.Resources
{
    public class Light : Resource
    {
        public override int Id { get; set; }

        public override string Name { get; set; }

        //true : ON, false = OFF
        public bool OnOff { get; set; }


        public bool Switch()
        {
            return OnOff = OnOff ? false : true;
        }

    }
}
