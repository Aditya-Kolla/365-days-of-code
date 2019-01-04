n = int(input())
size = int(input())
drives = [i for i in range(n)]
while n > 0:
    drives[n - 1] = int(input())
    n -= 1
drives.sort(reverse=True)
rem = 0
i = 0
for d in drives:
    if rem >= size: break
    else: rem += d
    i += 1
print(i)