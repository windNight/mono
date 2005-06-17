//
// System.Security.Policy.IdentityReferenceCollection.cs
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0

using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Principal {

	[ComVisible (false)]
	public class IdentityReferenceCollection : IEnumerable, ICollection<IdentityReference>, IEnumerable<IdentityReference> {

		private ArrayList _list;

		public IdentityReferenceCollection ()
		{
			_list = new ArrayList ();
		}

		public IdentityReferenceCollection (int capacity)
		{
			_list = new ArrayList (capacity);
		}


		public virtual int Count {
			get { return _list.Count; }
		}

		public virtual bool IsReadOnly {
			get { return false; }
		}

		public IdentityReference this [int index] {
			get {
				if (index >= _list.Count)
					return null;
				return (IdentityReference) _list [index];
			}
			set { _list [index] = value; }
		}


		public void Add (IdentityReference identity)
		{
			_list.Add (identity);
		}

		public void Clear ()
		{
			_list.Clear ();
		}

		public bool Contains (IdentityReference identity)
		{
			foreach (IdentityReference id in _list) {
				if (id.Equals (identity))
					return true;
			}
			return false;
		}

		[MonoTODO]
		public void CopyTo (IdentityReference[] array, int offset)
		{
		}

		[MonoTODO]
		public IEnumerator<IdentityReference> GetEnumerator ()
		{
			return null;
		}

		[MonoTODO]
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return null;
		}

		public bool Remove (IdentityReference identity)
		{
			foreach (IdentityReference id in _list) {
				if (id.Equals (identity)) {
					_list.Remove (id);
					return true;
				}
			}
			return false;
		}

		[MonoTODO]
		public IdentityReferenceCollection Translate (Type targetType)
		{
			return null;
		}

		[MonoTODO]
		public IdentityReferenceCollection Translate (Type targetType, bool forceSuccess)
		{
			return null;
		}
	}
}

#endif
