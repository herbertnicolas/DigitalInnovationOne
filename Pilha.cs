using System;
using DigitalInnovationOne;

namespace DigitalInnovationOne
{
    public class Pilha{
        Posicao primeiro;

        public void Empilha(object item){
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha(){
            if(primeiro == null){
                throw new InvalidOperationException();
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao{
            public object item;
            public Posicao proximo;

            public Posicao(Posicao proximo, object item){
                this.item = item;
                this.proximo = proximo;
            }
        }
    }

}