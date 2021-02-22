using System;

namespace GenericExample
{
    public class Box<T> 
    {
        public T Content { get; private set;  } 
        private bool HasContent { get; set;  }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        public void Put (T content)
        {
            Content = (HasContent) ? throw new Exception("Ya hay un contenido en la caja") : content;  /// ?????? 

            HasContent = true; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T Extract()
        {
            if(!HasContent)
            {
                throw new Exception("No hay nada para extraer"); 
            }
            T content = this.Content;
            this.Content = default(T);
            HasContent = false;
            return content; 
        }

    }
}
