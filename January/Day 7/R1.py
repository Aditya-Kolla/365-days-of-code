t = int(input())

while t > 0:
	quote = input().split(' ')
	if "not" in quote: print('Real Fancy')
	else: print('regularly fancy')
	t -= 1