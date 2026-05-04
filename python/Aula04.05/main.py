# recursão é uma operação de repetição via empilhamento de processo
# toda repetição precisa de 3 situações de ATENÇÃO:
# inicialização da variável de controle
# condição de parada
# atualização da variável de controle
# contras de usar recursão:
# pode causar estouro de pilha (stack overflow) se a profundidade da recursão for muito grande
# pode ser menos eficiente em termos de tempo e memória do que soluções iterativas,

# pros de usar recursão:
# pode tornar o código mais simples e fácil de entender

def contagem_regressiva(n): # n é a variável de controle
    if n > 0: # condição de parada
        print(n) # codigo executado no empilhamento de processo
        contagem_regressiva(n - 1) # atualização da variável de controle, a cada chamada recursiva o valor de n diminui em 1

def contagem_progressiva(n):
    if n > 0:
        contagem_progressiva(n - 1)
        print(n) # codigo executado no desempilhamento de processo

def soma_elementos(n):
    if n > 10:
        return n + soma_elementos(n - 1)
    else:
        return 0

# main
# contagem_regressiva(10)
contagem_progressiva(10)