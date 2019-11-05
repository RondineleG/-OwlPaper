print('*********************************')
print('***Bem vindo ao jogo da Forca!***')
print('*********************************')

    palavra_secreta = 'banana' 
              


    print('Fim do jogo')
    certou = False
    enforcou= False

   while(not acertou and not errou):
        chute = input('Qual letra?')

        posicao = 0
        for letra in palavra_secreta:
            if (chute == letra):
                print('Encontrei a letra {} na posição {}'.format(letra, index))
            posicao = posicao + 1  

        print('Jogando...')