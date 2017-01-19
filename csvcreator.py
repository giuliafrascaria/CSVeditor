import csv

generalCSV = open('reservations.csv')
singlelineCSV = open('singleline.csv', 'wt')

try:

    readerFile = csv.reader(generalCSV)
    csvWriter = csv.writer(singlelineCSV)
    dataList = list(readerFile)
    j = 1
    for i in range (2, len(dataList)):
        row = dataList[i]
        print i
        if len(row) <= 3:
            print str(j) + "j"
            prevrow = dataList[i - j]
            smallrow = dataList[i]
            prevrow.extend(smallrow)
            pr
            #vado avanti di una riga iterando il ciclo for
            j+=1 #ma mi segno che devo incollare tutto una riga piu indietro
        else:
            csvWriter.writerow(dataList[i - j])
            j = 1
            print row
            #copio la riga nel csv corretto
            print "row normale"
        csvWriter.writerow(dataList[i])
finally:
    generalCSV.close()


