using System;

// ReSharper disable CheckNamespace

namespace GameLovers.UiService
{
	/// <summary>
	/// Represents a configuration of an <seealso cref="UiPresenter"/> with all it's important data
	/// The Id is the int representation of the UI generated by the UiIdsGenerator code generator
	/// </summary>
	[Serializable]
	public struct UiConfig
	{
		public string AddressableAddress;
		public int Layer;
		public Type UiType;
	}
}