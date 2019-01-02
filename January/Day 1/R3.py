input()
f = input()
if f.count('xxx') == 0: 
    print("0")
else:
    i = 0
    p = f.find('xxx')
    while p != -1:
        f = f.replace('xxx', 'xx', 1)
        i += 1
        p = f.find('xxx')
    print(i)
