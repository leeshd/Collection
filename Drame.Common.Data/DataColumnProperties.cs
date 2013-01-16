using System;

namespace Drame.Common.Data
{
	public class DataColumnProperties
	{
		public const string SHOWLIST_FIELD = "ShowList";
		/// <summary>
		/// 是否在列表中显示
		/// </summary>
		/// <value>
		/// <c>true</c> if show list; otherwise, <c>false</c>.
		/// </value>
		public bool ShowList {
			get;
			set;
		}

		public const string SHOWDETAIL_FIELD = "ShowDetail";
		/// <summary>
		/// 在详情中显示
		/// </summary>
		/// <value>
		/// <c>true</c> if show detail; otherwise, <c>false</c>.
		/// </value>
		public bool ShowDetail {
			get;
			set;
		}

		public const string COLUMNSPAN_FIELD = "ColumnSpan";
		/// <summary>
		/// 占用列数
		/// </summary>
		/// <value>
		/// The column span.
		/// </value>
		public int ColumnSpan {
			get;
			set;
		}

		public const string ROWSPAN_FIELD = "RowSpan";
		/// <summary>
		/// 占用行数
		/// </summary>
		/// <value>
		/// The row span.
		/// </value>
		public int RowSpan {
			get;
			set;
		}

		public const string NAME_FIELD = "Name";
		/// <summary>
		/// 
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name {
			get;
			set;
		}

		public const string LABEL_FIELD = "Label";

		public string Label {
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public const string CONTROL_FIELD = "Control";
		/// <summary>
		/// Gets or sets the control class.
		/// </summary>
		/// <value>
		/// control classname.
		/// </value>
		public string Control {
			get;
			set;
		}

		public const string CHECKABLE_FIELD = "Checkable";

		public bool Checkable {
			get;
			set;
		}

		public const string INFO_FIELD = "Info";
		/// <summary>
		/// 输入提示信息
		/// </summary>
		/// <value>
		/// The info.
		/// </value>
		public string Info {
			get;
			set;
		}

		public const string FORE_FIELD = "Fore";
		/// <summary>
		/// 前景色 #RRGGBB
		/// </summary>
		/// <value>
		/// The fore.
		/// </value>
		public string Fore {
			get;
			set;
		}

		public const string BACK_FIELD = "Back";
		/// <summary>
		/// 背景色 #RRGGBB
		/// </summary>
		/// <value>
		/// The back.
		/// </value>
		public string Back {
			get;
			set;
		}

		public const string ICON_FIELD = "Icon";

		/// <summary>
		/// 图标名称
		/// </summary>
		/// <value>
		/// The icon.
		/// </value>
		public string Icon {
			get;
			set;
		}

		public const string FONT_FIELD = "Font";
		/// <summary>
		/// 字体名称
		/// </summary>
		/// <value>
		/// The font.
		/// </value>
		public string Font {
			get;
			set;
		}

		public const string TEXTSIZE_FIELD = "TextSize";
		/// <summary>
		/// 文字大小
		/// </summary>
		/// <value>
		/// The size of the text.
		/// </value>
		public int TextSize {
			get;
			set;
		}

		public const string MIN_FIELD = "Min";

		public int Min {
			get;
			set;
		}

		public const string MAX_FIELD = "Max";

		public int Max {
			get;
			set;
		}

		public const string MIN_LENGTH_FIELD = "Min_Length";

		public int Min_Length {
			get;
			set;
		}

		public const string MAX_LENGTH_FIELD = "Max_Length";

		public int Max_Length {
			get;
			set;
		}

		public const string FORMAT_FIELD = "Format";

		public string Format {
			get;
			set;
		}

		public const string ORIENTATION_FIELD = "Orientation";

		public string Orientation {
			get;
			set;
		}

		public const string PROMPT_FIELD = "Prompt";

		public string Prompt {
			get;
			set;
		}

		public const string GROUP_FIELD = "Group";
		public string Group
		{
			get;
			set;
		}

		public const string HINT_FIELD = "Field";
		public string Hint
		{
			get;
			set;
		}

		public const string RELATION_FIELD = "Relation";
		public string Relation {
			get;
			set;
		}

		public const string PARENT_FIELD = "Parent";
		public string Parent
		{
			get;
			set;
		}

		public const string PARENTOUT_FIELD = "ParentOut";
		public string ParentOut
		{
			get;
			set;
		}

		public const string PARENTINIT_FIELD="ParentInit";
		public string ParentInit
		{
			get;
			set;
		}

		public const string UPLOAD_FIELD = "Upload";
		public string Upload
		{
			get;
			set;
		}

		public const string REQUIRED_FIELD = "Required";
		public string Required
		{
			get;
			set;
		}

		public const string SOURCE_FIELD = "Source";
		public string Source
		{
			get;
			set;
		}

		public const string MODE_FIELD = "Mode";
		public string Mode
		{
			get;
			set;
		}

		public const string REQUEST_FIELD = "Request";
		public string Request
		{
			get;
			set;
		}

		public const string TEXT_FIELD = "Text";
		public string Text
		{
			get;
			set;
		}

		public const string VALUE_FIELD = "Value";
		public object Value
		{
			get;
			set;
		}

		public const string VISIBLE_FIELD = "Visible";
		public bool Visible
		{
			get;
			set;
		}

		public const string Editable_Field = "Editable";
		public bool Editable
		{
			get;
			set;
		}

		public const string NULLABLE_FIELD = "Nullable";
		public bool Nullable
		{
			get;
			set;
		}

		public const string Panel_Field = "Panel";
		public string Panel
		{
			get;
			set;
		}

	}

}