﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using dnSpy.Contracts.Debugger.Evaluation;

namespace dnSpy.Debugger.Evaluation.ViewModel {
	abstract class ValueNodesProvider {
		/// <summary>
		/// Gets all nodes. Caller owns the nodes and must close them.
		/// </summary>
		/// <returns></returns>
		public abstract DbgValueNode[] GetNodes();

		/// <summary>
		/// Raised when <see cref="GetNodes"/> must be called again, eg. the debugged program is paused
		/// </summary>
		public abstract event EventHandler NodesChanged;

		/// <summary>
		/// true if the window should be made read-only, eg. the program is running or nothing is being debugged.
		/// </summary>
		public abstract bool IsReadOnly { get; }
		public abstract event EventHandler IsReadOnlyChanged;
	}
}
