


def run():
    input_data = open('mofit.in','r' )
    output_data = open("mofit.out","w")
    n = int(input_data.readline())
    for i in range(0,n):
        points = ''
        sequence = input_data.readline().strip()
        mofit =  input_data.readline().replace("\n","").strip()
        mofit_len = len(mofit)
        sequence_len = len(sequence)
        for j in range(0,sequence_len-mofit_len+1):
            if sequence[j:j+mofit_len] == mofit:
                point = j+1
                points =points + str(point) + " "
        output_data.writelines(points.strip()+"\n")
    output_data.close()
    input_data.close()



run()