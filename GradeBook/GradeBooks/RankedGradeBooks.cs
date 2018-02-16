﻿using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
	class RankedGradeBooks : BaseGradeBook
	{
		public RankedGradeBooks(string name) : base(name)
		{
			Type = GradeBookType.Ranked;
		}
	}
}
