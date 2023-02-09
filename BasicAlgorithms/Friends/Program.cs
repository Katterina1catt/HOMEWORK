int count,firstRriendSpeed,secondRriendSpeed,dogspeed,friend;//camelCase
double time,distance;
count=0;
distance=10000;
firstRriendSpeed=1;
secondRriendSpeed=2;
dogspeed=5;
friend=2;
while(distance>10)
{
    if (friend==1)
    { 
      time=distance/(firstRriendSpeed+dogspeed);
      friend=2;
    }
    else
    { 
      time=distance/(secondRriendSpeed+dogspeed);
      friend=1;
    }
    distance=distance-(firstRriendSpeed+secondRriendSpeed)*time;
    count=count+1;
}
System.Console.WriteLine(count);
// int Count,Distance
