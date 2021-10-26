class program
{
  public constant int IS_PART_TIME =1;
  public constant int IS_FULL_TIME =2;
  public constant int  EMP_RATE_PER_HOUR = 20;
  public constant int  NUM_OF_WORKING_DAYS = 2;
  public constant int  MAX_HRS_IN_MONTH = 10;
  1 reference
  public static int computerEmpWage()
  {
  // variables
  int empHrs  = 0,totalEmpHrs = 0,totalWorkingDays = 0;
  // computation
  while (totalEmpHrs  <=MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
  {
     totalWorkingDays++;
     Random random = num Random();
     int empCheck random.Next(0, 3);
     switch (empCheck)
     {
     case IS_PART_TIME;
        empHrs  =4;
     case IS_FULL_TIME;
         empHrs  =8;
         break;
      default:
         empHrs  =0;
         break;
      }
      totalEmpHrs +=empHrs;
      Console.WriteLine("Day#:"  + totalWorkingDays  +" EmpHrs  :" + empHrs);  }
  }
  int totalEmpWage = totalEmpHrs = totalEmpHrs *EMP_RATE_PER_HOUR;
  Console.WriteLine("Total Emp Wage :"  + totalEmpWage);
  return totalEmpWage;
  }
  0 reference 
  static void Main(String[] args)
  {
        computeEmpWage();
  }
