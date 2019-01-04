t = input().split(' ')
n, s = int(t[0]), int(t[1])
r = int(s/n)
print(r + 1) if r*n != s else print(r)