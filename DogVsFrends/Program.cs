// Сколько раз собака пробежит между идущими 
// навстречу друг другу друзьями
int count =0;
int friendStart=2;        //друг от которого начнет бегать собачка
int friend = friendStart; //текущий друг
double dist = 20; //начальная дистанция
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
        friend=1;
    }
    dist=dist-(firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}

Console.WriteLine(count%2);

if (count%2 ==0)
{
    friend=friendStart;
}

//Console.Clear();
Console.Write("Стартовав от ");
Console.Write(friendStart);
Console.Write("-го друга собака пробежит ");
Console.Write(count);
Console.Write(" раз, окажется около ");
Console.Write(friend);
Console.WriteLine("-го друга.");

