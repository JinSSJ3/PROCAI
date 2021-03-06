﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Guia : TrabajadorOCAI
    {
        protected static int i = 0;
        private int IdGuia;
        private TipoGuia tipoGuia;
        private string licencia;
        private List<GrupoEncuestas> gruposDondeFueEvaluado;
        private List<Encuesta> encuestasDigitadas;

        public Guia(string dNI, string nombres, string apellidoPaterno, string apellidoMaterno, int celular, TipoSexo sexo, string correoElectronico, DateTime fechaIngreso, int estadoTrabajador, int telefonoOfi, int celularOfi, string correOfi, TipoGuia tipoGuia, string licencia) : base(dNI, nombres, apellidoPaterno, apellidoMaterno, celular, sexo, correoElectronico, fechaIngreso, estadoTrabajador, telefonoOfi, celularOfi, correOfi)
        {
            IdGuia = ++i;
            this.tipoGuia = tipoGuia;
            this.licencia = licencia;
        }

        public int IdGuia1 { get => IdGuia; set => IdGuia = value; }
        public TipoGuia TipoGuia { get => tipoGuia; set => tipoGuia = value; }
        public string Licencia { get => licencia; set => licencia = value; }
        public List<GrupoEncuestas> GruposDondeFueEvaluado { get => gruposDondeFueEvaluado; set => gruposDondeFueEvaluado = value; }
        public List<Encuesta> EncuestasDigitadas { get => encuestasDigitadas; set => encuestasDigitadas = value; }

        public void addEncuestaDigitada(Encuesta enc)
        {
            this.encuestasDigitadas.Add(enc);
            enc.Digitador = this;
        }
        public void addGrupoDondeFueEvaluado(GrupoEncuestas gru)
        {
            this.gruposDondeFueEvaluado.Add(gru);
            gru.GuiaEvaluado = this;
        }
    }
}
