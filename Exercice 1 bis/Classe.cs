﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1bis
{
	public class Classe
	{
		private string _matiere;
		private Professeur _prof;
		private List<Etudiant> etudiants;

		public List<Etudiant> Etudiants
		{
			get { return etudiants; }
			set { etudiants = value; }
		}

		public Professeur Prof
		{
			get { return _prof; }
			set { _prof = value; }
		}

		public string Matiere
		{
			get { return _matiere; }
			set { _matiere = value; }
		}

		public void SePresenter()
		{
			Console.Write($"la classe de {Matiere} est enseigné par {Prof.Genre} {Prof.Nom} {Prof.Prenom} et les étudiants participant au cours sont ");
			foreach (Etudiant student in Etudiants)
			{
				Console.Write($"{student.Nom} {student.Prenom} ");
			}

		}
	}

}