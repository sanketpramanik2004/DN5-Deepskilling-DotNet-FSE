Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();
logger1.Log("Application Started");
logger2.Log("User logged in");
if(ReferenceEquals(logger1, logger2)){
    Console.WriteLine("Same Instances");
}
else{
    Console.WriteLine("Different Instances");
}