
// Обробка виключень

// try - catch - finally

//try
//{
//    int[] nums = { 1, 2, 3, 4 };
//    nums[5] = 8;
//    Console.WriteLine("After exception");
//}
//catch
//{
//    Console.WriteLine("Exception happened");
//}
//finally
//{
//    Console.WriteLine("Block finally");
//}


// Exception 

// InvalidOutOfRangeException
// IndexOutOfRangeException
// ...

//try
//{
//    int[] nums = { 1, 2, 3, 4 };
//    nums[5] = 8;
//}
//catch(InvalidCastException)
//{
//    Console.WriteLine("InvalidCastException happened");
//}
//catch (IndexOutOfRangeException)
//{
//    Console.WriteLine("IndexOutOfRangeException happened");
//}
//catch (Exception)
//{
//    Console.WriteLine("Exception happened");
//}
//finally
//{
//    Console.WriteLine("Block finally");
//}

//try
//{
//    int[] nums = { 1, 2, 3, 4 };
//    nums[5] = 8;
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Exception happened");
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.TargetSite);
//    Console.WriteLine(ex.Source);
//}
//finally
//{
//    Console.WriteLine("Block finally");
//}

try
{
    string country = "Ac";
    if (string.IsNullOrEmpty(country) || country.Length < 3)
    {
        throw new Exception("country must be 3 symbols and more");
    }   
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


