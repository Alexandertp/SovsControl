
int i = 0;
while (i < 4) {
EatMyCPU();
i++;
}

void EatMyCPU() {
int EatI = 0;
while (EatI < 10000) {
    i++;
}
Console.Writeline("Done!");
}