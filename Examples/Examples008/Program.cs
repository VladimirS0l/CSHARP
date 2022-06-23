
int count = 0;
int distance = 10000;
int firstSpeedF = 1;
int secondSpeedF = 2;
int dogSpeed = 5;
int friend = 2;
int time;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (firstSpeedF + dogSpeed);
        friend = 2;
        distance = distance - (firstSpeedF + secondSpeedF) * time;
        count += 1;
    }

    else
    {
        time = distance / (secondSpeedF + dogSpeed);
        friend = 1;
        distance = distance - (firstSpeedF + secondSpeedF) * time;
        count += 1;
    }
}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз");

