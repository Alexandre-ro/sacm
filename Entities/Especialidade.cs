﻿namespace SACM.Entities
{
    public class Especialidade
    {
        public int Codigo { get; set; }      
        public string Nome { get; set; }
        public List<Medico> Medicos { get; set; }
    }
}
