using System;

namespace Code
{
    public  class ReverseString
    {
        public string ReverseV1(string stringToReverse)
        {
            var characters = stringToReverse.ToCharArray();

            Array.Reverse(characters);
            
            return new string(characters);
        }


        public string ReverseV2(string arg)
        {
            throw new NotImplementedException();
        }
    }
}
