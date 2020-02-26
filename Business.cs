using System;

namespace Assign3
{
    public class Business : Property

    {
        string name;
        enum BusinessType { Grocery, Bank, Repair, FastFood, DepartmentStore }
        readonly string yearEstablished;
        uint activeRecruitment;

        protected override void residenceInfo()
        {
            Console.WriteLine($"{streetAddr}");
        }

        public string businessAddress()
        {
            return $"{streetAddr}";
        }
        public Business() : base()
            {
            name = "";
            yearEstablished = "";
            activeRecruitment = 0;
            }

        public Business(string[] input) : base(input)
        {
            name = stringParser();
            yearEstablished = stringParser();
            activeRecruitment = uintParser();
        }

        public override string ToString()
        {
            return $"{name}, a type of business, established in {yearEstablished}";
        }

}
}
