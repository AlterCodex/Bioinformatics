


def run():
    input_data = open('bee_population.in','r' )
    output_data = open("bee_population.out","w")
    n = int(input_data.readline())
    for i in range(0,n):
        result = ''
        data = input_data.readline().strip().split(' ')
        n_0 = float(data[0])
        a = float(data[1])
        b = float(data[2])
        n_1 = a*n_0-b*n_0*n_0
        if n_1 > n_0:
            result = str(-1)+'\n'
        elif n_1 < n_0:
            result = str(0)+'\n'
        else:
            result = str(n_0)+'\n'
        output_data.writelines(result)
    output_data.close()
    input_data.close()

run()