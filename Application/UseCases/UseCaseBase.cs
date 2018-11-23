using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public abstract class UseCaseBase<TInput, TOutput>
    {
        public TOutput Execute(TInput input)
        {
            LogUseCase(input);

            if(CheckRights(input))
            {
                return ExecuteCore(input);
            }
            else
            {
                throw new Exception();
            }
        }

        private void LogUseCase(TInput input)
        {
            Logger.Log($"L'utilisateur {currentUser.Name} a lancé la tache {this.GetType().Name}");
            Logger.Log(JSONConvert.ToJson(input));

        }

        protected abstract TOutput ExecuteCore(TInput input);

        protected abstract bool CheckRights(TInput input);
    }
}
