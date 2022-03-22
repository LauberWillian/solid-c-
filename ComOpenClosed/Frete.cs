﻿namespace WebApplication1.ComOpenClosed
{
    public class Frete
    {
        private IFreteServico _freteServico;
        public Frete(IFreteServico freteServico)
        {
            _freteServico = freteServico;
        }

        public double Calcular(double peso)
        {
            return _freteServico.Calcular(peso);
        }
    }
}
