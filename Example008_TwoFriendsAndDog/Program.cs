double vDog = 20, vFriend1 = 5, vFriend2 = 5, s = 1000;
int flag = 2, n = 0; 
double dN = s;
while (dN > 10) {
    if (flag == 2) {
        flag = 1;
        n++;
        dN = dN - (vFriend1 + vFriend2) * (dN / (vDog + vFriend2));
    }
    else if (flag == 1) {
        flag = 2;
        n++;
        dN = dN - (vFriend1 + vFriend2) * (dN / (vDog + vFriend1));
    }
}
Console.WriteLine(n);