// Сколько раз собака пробежит между идущими 
// навстречу друг другу друзьями
int count =0;
int friend=1;     //друг от которого начнет бегать собачка 
double dist = 10; //начальная дистанция
double distEnd=1;    //финишная дистанция
double firstFriendSpeed=1;
double secondFriendSpeed=2;
double dogSpeed = 5;
double time = 0;

while (dist > distEnd)
{
    if (friend == 1)
    {
        time = dist/(firstFriendSpeed+dogSpeed);
        friend=2;
    }
    if (friend == 2)
    {
        time=dist/(secondFriendSpeed+dogSpeed);
        friend=2;
    }
    dist=dist-(firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}

Console.Clear();
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз,");

