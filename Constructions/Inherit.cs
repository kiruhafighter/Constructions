using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructions
{
    internal class Inherit : Class1
    {
        string pasid;
        public Inherit(){}
        public Inherit(int age, string name , string pasid) : base(age, name)
        {
            this.pasid = pasid;
        }
        public override void Show()
        {
            Console.WriteLine($"New Person Pasport ID {pasid}");
        }
        public int GetMax(params int[] nums)
        {
            int result = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if(result < nums[i])
                {
                    result = nums[i];
                }
            }
            return result;

        }
    }
}
