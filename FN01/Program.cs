using System;
class Program
{
    static void InputDistance(LinkedList<int> distanceList)
    {
        int inputDistance;
        while(true)
        {
            Console.WriteLine("*****************");
            Console.Write("INPUT : ");
            inputDistance = int.Parse(Console.ReadLine());
            if(inputDistance <= 0)
            {
                break;
            }
            distanceList.Add(inputDistance);
        }
    }

    static int GetMinDistanceIndex(LinkedList<int> distanceList)
    {
        int minDistanceIndex = 0;
        int minDistance = distanceList.Get(-1) + distanceList.Get(0);

        int currentDistance;
        for(int i=1; i<distanceList.GetLength(); i++)
        {
            currentDistance = distanceList.Get(i-1) + distanceList.Get(i);
            if(currentDistance < minDistance)
            {
                minDistanceIndex = i;
                minDistance = currentDistance;
            }
        }

        return minDistanceIndex;
    }

    static void RemoveMinDistance(LinkedList<int> distanceList)
    {
        if(distanceList.GetLength() > 0)
        {
            int minDistanceIndex = GetMinDistanceIndex(distanceList);
            distanceList.Set(minDistanceIndex-1, distanceList.Get(minDistanceIndex-1) + distanceList.Get(minDistanceIndex));
        }
    }

    static void Main(string[] args)
    {
        LinkedList<int> distanceList = new LinkedList<int>();
        InputDistance(distanceList);

        int removedDistanceCount = int.Parse(Console.ReadLine());
        while(removedDistanceCount > 0)
        {
            RemoveMinDistance(distanceList);
            removedDistanceCount--;
        }

        for(int i=0; i<distanceList.GetLength(); i++)
        {
            Console.WriteLine("*****************");
             Console.Write("OUTPUT : ");
            Console.WriteLine(distanceList.Get(i));
        }
    }
    
}

//เมื่อรันโปรแกรมแล้วใส่จำนวนต่ำกว่า0ทางโปรแกรมจะให้ผู้ใช้ใส่เลขอีก1ตัวถึงจะOUTPUTออก