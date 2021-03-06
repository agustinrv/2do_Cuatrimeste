﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AdminPersonas
{
    public partial class frmPersona : Form 
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }

        public frmPersona()
        {
            InitializeComponent();
            this.miPersona = new Persona();
        }
        public frmPersona(Persona p):this()
        {
            this.miPersona = p;
            this.txtApellido.Text = Persona.apellido;
            this.txtNombre.Text = Persona.nombre;
            this.txtEdad.Text = Persona.edad.ToString();

        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //implementar
            miPersona.nombre = txtNombre.Text;
             miPersona.apellido=txtApellido.Text;
             miPersona.edad=int.Parse(txtEdad.Text);
             
             this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
