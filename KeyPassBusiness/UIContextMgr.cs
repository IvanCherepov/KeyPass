using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyPassInfoModel;

namespace KeyPassBusiness
{


	public static class UIContextMgr
	{
		private static Group _selectedGroup = null;

		private static Key _modifiedKey = new Key();

		private static List<Key> _selectedKeys = new List<Key>();
		
		private static Group _group = null;
		private static Key _key = new Key();

		public delegate void GroupAddedEventHandler(Group g);
		public delegate void GroupModifiedEventHadnler(Group g);
		public delegate void GroupDeletedEvenHandler(Group g);
		public delegate void GroupSelectedEventHadnler(Group g);

		public delegate void KeyAddedEventHandler(Group g,Key k);
		public delegate void KeyEditedEventHandler(Group g,Key k);
		public delegate void KeyModifiedEventHandler(Key k);
		public delegate void KeyDeletedEvenHandler(Group g,Key k);
		public delegate void KeysSelectedEventHandler(List<Key> keys);

		public static event GroupAddedEventHandler GroupAdded;
		public static event GroupModifiedEventHadnler GroupModified;
		public static event GroupDeletedEvenHandler GroupDeleted;
		public static event GroupSelectedEventHadnler GroupSelected;

		public static event KeyAddedEventHandler KeyAdded;
		public static event KeyEditedEventHandler KeyEdited;
		public static event KeyModifiedEventHandler KeyModified;
		public static event KeyDeletedEvenHandler KeyDeleted;
		public static event KeysSelectedEventHandler KeySelected;

		public static void Initialize()	
		{
			_selectedGroup = null;
			_selectedKeys = new List<Key>();
		}

		public static Group AddedGroup
		{
			get { return _group; }
			set
			{
				_group = value;

				if (GroupAdded != null)
				{
					GroupAdded(value);
				}
			}
		}

		public static Group ModifiedGroup
		{
			get { return _group; }
			set
			{
				_group = value;

				if (GroupModified != null)
				{
					GroupModified(value);
				}
			}
		}

		public static Group DeletedGroup
		{
			get { return _group; }
			set
			{
				_group = value;

				if (GroupDeleted != null)
				{
					GroupDeleted(value);
				}
			}
		}

		public static Group SelectedGroup
		{
			get { return _selectedGroup; }
			set
			{
				_selectedGroup = value;

				if (GroupSelected != null)
				{
					GroupSelected(value);
				}
			}
		}

		public static void FireGroupSelected()
		{
			if (GroupSelected != null)
			{
				GroupSelected.Invoke(_selectedGroup);
			}
		}

		public static void FireKeyAdded(Group g,Key k)
		{
			if (KeyAdded!= null)
			{
				KeyAdded.Invoke(g,k);
			}
		}

		public static void FireKeyEdited(Group g, Key k)
		{
			if (KeyEdited != null)
			{
				KeyEdited.Invoke(g, k);
			}
		}

		public static void FireKeyDeleted(Group g, Key k)
		{
			if (KeyDeleted != null)
			{
				KeyDeleted.Invoke(g, k);
			}
		}

		public static List<Key> SelectedKeys
		{
			get { return _selectedKeys; }
			set
			{
				_selectedKeys = value;

				if (KeySelected != null)
				{
					KeySelected(value);
				}
			}
		}

		public static void SetKeySelected()
		{
			if (KeySelected != null)
			{
				KeySelected.Invoke(_selectedKeys);
			}
		}

		public static Key ModifiedKey
		{
			get { return _key; }
			set
			{
				_key = value;
				if (ModifiedKey != null)
				{
					KeyModified(value);
				}
			}
		}

		public static void SetKeyModified()
		{
			if (ModifiedKey != null)
			{
				KeyModified.Invoke(_key);
			}
		}

	}
}
