#input = singleline.csv
#output = newreservations.csv con colonne con nomi diversi

#Utente,Risorsa,Nome,Descrizione,Inizio,Fine,Durata,Creato,Ultima modifica,Numero riferimento,Corso di studi,Nome docente,

#Email, Resource names, Title, Description, Begin, End, Corso di studi, Nome docente
import csv
import datetime

source = open('singleline.csv')
result = open('upload.csv', 'wt')


#-------------------elaborazione 2, elaboro il file assegnando a ogni slot orario un numero----------------------
try:
    rdr = csv.reader(source)
    wtr = csv.writer(result)

    wtr.writerow(["email", "resource names", "title", "description", "begin", "end", "Corso di studi", "Nome docente"])
    #﻿email,resource names,title,description,begin,end,Corso di studi,Nome docente

    for r in rdr:
        europeanStartDate = r[4].split(" ")
        europeanEndDate = r[5].split(" ")

        begin = datetime.datetime.strptime(europeanStartDate[0], "%d/%m/%Y").strftime("%Y/%m/%d")
        end = datetime.datetime.strptime(europeanEndDate[0], "%d/%m/%Y").strftime("%Y/%m/%d")

        wtr.writerow((r[0], r[1], r[2], r[3], begin+" "+europeanStartDate[1], end+" "+europeanEndDate[1], r[10], r[11]))

finally:
    source.close()
    result.close()