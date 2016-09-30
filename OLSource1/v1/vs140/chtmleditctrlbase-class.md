---
title: "CHtmlEditCtrlBase Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CHtmlEditCtrlBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHtmlEditCtrlBase class"
ms.assetid: e0cc74b4-8320-4570-b673-16c03d2ae266
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase Class
Represents an HTML editing component.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHtmlEditCtrlBase::AddToGlyphTable](#chtmleditctrlbase__addtoglyphtable)|Adds an entry to the glyph table, which specifies images to display for specific tags in design mode.|  
|[CHtmlEditCtrlBase::Bold](#chtmleditctrlbase__bold)|Toggles the bold state of the selected text.|  
|[CHtmlEditCtrlBase::Button](#chtmleditctrlbase__button)|Overwrites a button control on the current selection.|  
|[CHtmlEditCtrlBase::CheckBox](#chtmleditctrlbase__checkbox)|Overwrites a check box control on the current selection.|  
|[CHtmlEditCtrlBase::ClearSelection](#chtmleditctrlbase__clearselection)|Clears the current selection.|  
|[CHtmlEditCtrlBase::Copy](#chtmleditctrlbase__copy)|Copies the current selection to the clipboard.|  
|[CHtmlEditCtrlBase::Cut](#chtmleditctrlbase__cut)|Copies the current selection to the clipboard and then deletes it.|  
|[CHtmlEditCtrlBase::Delete](#chtmleditctrlbase__delete)|Deletes the current selection.|  
|[CHtmlEditCtrlBase::DropDownBox](#chtmleditctrlbase__dropdownbox)|Overwrites a drop-down selection control on the current selection.|  
|[CHtmlEditCtrlBase::EmptyGlyphTable](#chtmleditctrlbase__emptyglyphtable)|Removes all entries from the glyph table, which hides all images displayed for tags in design mode.|  
|[CHtmlEditCtrlBase::ExecCommand](#chtmleditctrlbase__execcommand)|Executes a command.|  
|[CHtmlEditCtrlBase::Font](#chtmleditctrlbase__font)|Opens a font dialog box to enable the user to change the text color, font, and font size of the current selection.|  
|[CHtmlEditCtrlBase::GetAbsolutePosition](#chtmleditctrlbase__getabsoluteposition)|Returns whether an element's position property is "absolute."|  
|[CHtmlEditCtrlBase::GetBackColor](#chtmleditctrlbase__getbackcolor)|Retrieves the background color of the current selection.|  
|[CHtmlEditCtrlBase::GetBlockFormat](#chtmleditctrlbase__getblockformat)|Retrieves the current block format tag.|  
|[CHtmlEditCtrlBase::GetBlockFormatNames](#chtmleditctrlbase__getblockformatnames)|Retrieves the strings corresponding to the available block format tags.|  
|[CHtmlEditCtrlBase::GetBookMark](#chtmleditctrlbase__getbookmark)|Retrieves the name of a bookmark anchor.|  
|[CHtmlEditCtrlBase::GetDocument](#chtmleditctrlbase__getdocument)|Retrieves the document object.|  
|[CHtmlEditCtrlBase::GetDocumentHTML](#chtmleditctrlbase__getdocumenthtml)|Retrieves the HTML of the current document.|  
|[CHtmlEditCtrlBase::GetDocumentTitle](#chtmleditctrlbase__getdocumenttitle)|Retrieves the document's title.|  
|[CHtmlEditCtrlBase::GetEvent](#chtmleditctrlbase__getevent)|Retrieves an interface pointer to the event object that contains information relevant to the most recent event.|  
|[CHtmlEditCtrlBase::GetEventSrcElement](#chtmleditctrlbase__geteventsrcelement)|Retrieves the object that fired the event.|  
|[CHtmlEditCtrlBase::GetFontFace](#chtmleditctrlbase__getfontface)|Retrieves the font name for the current selection.|  
|[CHtmlEditCtrlBase::GetFontSize](#chtmleditctrlbase__getfontsize)|Retrieves the font size for the current selection.|  
|[CHtmlEditCtrlBase::GetForeColor](#chtmleditctrlbase__getforecolor)|Retrieves the foreground (text) color of the current selection.|  
|[CHtmlEditCtrlBase::GetFrameZone](#chtmleditctrlbase__getframezone)|Returns the security zone of the current page in the web browser.|  
|[CHtmlEditCtrlBase::GetIsDirty](#chtmleditctrlbase__getisdirty)|Indicates whether the HTML document has changed.|  
|[CHtmlEditCtrlBase::GetShowAlignedSiteTags](#chtmleditctrlbase__getshowalignedsitetags)|Returns whether a glyph is displayed for all elements that have a **styleFloat** property.|  
|[CHtmlEditCtrlBase::GetShowAllTags](#chtmleditctrlbase__getshowalltags)|Returns whether the WebBrowser displays glyphs to show the location of all tags in a document.|  
|[CHtmlEditCtrlBase::GetShowAreaTags](#chtmleditctrlbase__getshowareatags)|Retrieves whether the WebBrowser displays a glyph for area tags.|  
|[CHtmlEditCtrlBase::GetShowBRTags](#chtmleditctrlbase__getshowbrtags)|Retrieves whether the WebBrowser displays a glyph for br tags.|  
|[CHtmlEditCtrlBase::GetShowCommentTags](#chtmleditctrlbase__getshowcommenttags)|Retrieves whether the WebBrowser displays a glyph for comment tags.|  
|[CHtmlEditCtrlBase::GetShowMiscTags](#chtmleditctrlbase__getshowmisctags)|Retrieves whether the WebBrowser displays all the tags shown in Microsoft Internet Explorer 4.0.|  
|[CHtmlEditCtrlBase::GetShowScriptTags](#chtmleditctrlbase__getshowscripttags)|Retrieves whether the WebBrowser displays a glyph for all the script tags.|  
|[CHtmlEditCtrlBase::GetShowStyleTags](#chtmleditctrlbase__getshowstyletags)|Retrieves whether the WebBrowser displays a glyph for all the style tags.|  
|[CHtmlEditCtrlBase::GetShowUnknownTags](#chtmleditctrlbase__getshowunknowntags)|Retrieves whether the WebBrowser displays a glyph for all unknown tags.|  
|[CHtmlEditCtrlBase::HorizontalLine](#chtmleditctrlbase__horizontalline)|Overwrites a horizontal line on the current selection.|  
|[CHtmlEditCtrlBase::HyperLink](#chtmleditctrlbase__hyperlink)|Inserts a hyperlink on the current selection.|  
|[CHtmlEditCtrlBase::IE50Paste](#chtmleditctrlbase__ie50paste)|Performs a paste operation compatible with Microsoft Internet Explorer 5.|  
|[CHtmlEditCtrlBase::Iframe](#chtmleditctrlbase__iframe)|Overwrites an inline frame on the current selection.|  
|[CHtmlEditCtrlBase::Image](#chtmleditctrlbase__image)|Overwrites an image on the current selection.|  
|[CHtmlEditCtrlBase::Indent](#chtmleditctrlbase__indent)|Increases the indent of the selected text by one indentation increment.|  
|[CHtmlEditCtrlBase::InsFieldSet](#chtmleditctrlbase__insfieldset)|Overwrites a box on the current selection.|  
|[CHtmlEditCtrlBase::InsInputButton](#chtmleditctrlbase__insinputbutton)|Overwrites a button control on the current selection.|  
|[CHtmlEditCtrlBase::InsInputHidden](#chtmleditctrlbase__insinputhidden)|Inserts a hidden control on the current selection.|  
|[CHtmlEditCtrlBase::InsInputImage](#chtmleditctrlbase__insinputimage)|Overwrites an image control on the current selection.|  
|[CHtmlEditCtrlBase::InsInputPassword](#chtmleditctrlbase__insinputpassword)|Overwrites a password control on the current selection.|  
|[CHtmlEditCtrlBase::InsInputReset](#chtmleditctrlbase__insinputreset)|Overwrites a reset control on the current selection.|  
|[CHtmlEditCtrlBase::InsInputSubmit](#chtmleditctrlbase__insinputsubmit)|Overwrites a submit control on the current selection.|  
|[CHtmlEditCtrlBase::InsInputUpload](#chtmleditctrlbase__insinputupload)|Overwrites a file upload control on the current selection.|  
|[CHtmlEditCtrlBase::Is1DElement](#chtmleditctrlbase__is1delement)|Determines if an element is statically positioned.|  
|[CHtmlEditCtrlBase::Is2DElement](#chtmleditctrlbase__is2delement)|Determines if an element is absolutely positioned.|  
|[CHtmlEditCtrlBase::Italic](#chtmleditctrlbase__italic)|Toggles the current selection between italic and nonitalic.|  
|[CHtmlEditCtrlBase::JustifyCenter](#chtmleditctrlbase__justifycenter)|Centers the format block in which the current selection is located.|  
|[CHtmlEditCtrlBase::JustifyLeft](#chtmleditctrlbase__justifyleft)|Left-justifies the format block in which the current selection is located.|  
|[CHtmlEditCtrlBase::JustifyRight](#chtmleditctrlbase__justifyright)|Right-justifies the format block in which the current selection is located.|  
|[CHtmlEditCtrlBase::ListBox](#chtmleditctrlbase__listbox)|Overwrites a list box selection control on the current selection.|  
|[CHtmlEditCtrlBase::Marquee](#chtmleditctrlbase__marquee)|Overwrites an empty marquee on the current selection.|  
|[CHtmlEditCtrlBase::NewDocument](#chtmleditctrlbase__newdocument)|Creates a new document.|  
|[CHtmlEditCtrlBase::OrderList](#chtmleditctrlbase__orderlist)|Toggles the current selection between an ordered list and a normal format block.|  
|[CHtmlEditCtrlBase::Outdent](#chtmleditctrlbase__outdent)|Decreases by one increment the indentation of the format block in which the current selection is located.|  
|[CHtmlEditCtrlBase::Paragraph](#chtmleditctrlbase__paragraph)|Overwrites a line break on the current selection.|  
|[CHtmlEditCtrlBase::Paste](#chtmleditctrlbase__paste)|Overwrites the contents of the clipboard on the current selection.|  
|[CHtmlEditCtrlBase::PrintDocument](#chtmleditctrlbase__printdocument)|Prints the current document.|  
|[CHtmlEditCtrlBase::PrintPreview](#chtmleditctrlbase__printpreview)|Opens the Print Preview window for the current document using either the default print preview template or a custom template.|  
|[CHtmlEditCtrlBase::QueryStatus](#chtmleditctrlbase__querystatus)|Call this method to query the status of commands.|  
|[CHtmlEditCtrlBase::RadioButton](#chtmleditctrlbase__radiobutton)|Overwrites a radio control on the current selection.|  
|[CHtmlEditCtrlBase::RefreshDocument](#chtmleditctrlbase__refreshdocument)|Refreshes the current document.|  
|[CHtmlEditCtrlBase::RemoveFormat](#chtmleditctrlbase__removeformat)|Removes the formatting tags from the current selection.|  
|[CHtmlEditCtrlBase::SaveAs](#chtmleditctrlbase__saveas)|Saves the current Web page to a file.|  
|[CHtmlEditCtrlBase::SelectAll](#chtmleditctrlbase__selectall)|Selects the entire document.|  
|[CHtmlEditCtrlBase::Set2DPosition](#chtmleditctrlbase__set2dposition)|Allows absolutely positioned elements to be moved by dragging.|  
|[CHtmlEditCtrlBase::SetAbsolutePosition](#chtmleditctrlbase__setabsoluteposition)|Sets an element's position property to "absolute" or "static."|  
|[CHtmlEditCtrlBase::SetAtomicSelection](#chtmleditctrlbase__setatomicselection)|Set atomic selection mode.|  
|[CHtmlEditCtrlBase::SetAutoURLDetectMode](#chtmleditctrlbase__setautourldetectmode)|Turns automatic URL detection on and off.|  
|[CHtmlEditCtrlBase::SetBackColor](#chtmleditctrlbase__setbackcolor)|Sets the background color of the current selection.|  
|[CHtmlEditCtrlBase::SetBlockFormat](#chtmleditctrlbase__setblockformat)|Sets the current block format tag.|  
|[CHtmlEditCtrlBase::SetBookMark](#chtmleditctrlbase__setbookmark)|Creates a bookmark anchor for the current selection or insertion point.|  
|[CHtmlEditCtrlBase::SetCSSEditingLevel](#chtmleditctrlbase__setcsseditinglevel)|Selects which CSS level (CSS1 or CSS2) the editor will support, if any.|  
|[CHtmlEditCtrlBase::SetDefaultComposeSettings](#chtmleditctrlbase__setdefaultcomposesettings)|Call this method to set the default compose settings.|  
|[CHtmlEditCtrlBase::SetDesignMode](#chtmleditctrlbase__setdesignmode)|Set design mode.|  
|[CHtmlEditCtrlBase::SetDisableEditFocusUI](#chtmleditctrlbase__setdisableeditfocusui)|Disables the hatched border and handles around an element that has edit focus.|  
|[CHtmlEditCtrlBase::SetDocumentHTML](#chtmleditctrlbase__setdocumenthtml)|Sets the HTML of the current document.|  
|[CHtmlEditCtrlBase::SetFontFace](#chtmleditctrlbase__setfontface)|Sets the font for the current selection.|  
|[CHtmlEditCtrlBase::SetFontSize](#chtmleditctrlbase__setfontsize)|Sets the font size for the current selection.|  
|[CHtmlEditCtrlBase::SetForeColor](#chtmleditctrlbase__setforecolor)|Sets the foreground (text) color of the current selection.|  
|[CHtmlEditCtrlBase::SetIE5PasteMode](#chtmleditctrlbase__setie5pastemode)|Sets the paste operation to be compatible with Microsoft Internet Explorer 5.|  
|[CHtmlEditCtrlBase::SetLiveResize](#chtmleditctrlbase__setliveresize)|Causes the WebBrowser to update an element's appearance continuously during a resizing or moving operation.|  
|[CHtmlEditCtrlBase::SetMultiSelect](#chtmleditctrlbase__setmultiselect)|Enables multiple selection.|  
|[CHtmlEditCtrlBase::SetOverrideCursor](#chtmleditctrlbase__setoverridecursor)|Commands the WebBrowser never to change the mouse pointer.|  
|[CHtmlEditCtrlBase::SetOverwriteMode](#chtmleditctrlbase__setoverwritemode)|Toggles the text-entry mode between insert and overwrite.|  
|[CHtmlEditCtrlBase::SetRespectVisInDesign](#chtmleditctrlbase__setrespectvisindesign)|Hides invisible elements in design mode.|  
|[CHtmlEditCtrlBase::SetShowAlignedSiteTags](#chtmleditctrlbase__setshowalignedsitetags)|Displays a glyph for all elements that have a **styleFloat** property.|  
|[CHtmlEditCtrlBase::SetShowAllTags](#chtmleditctrlbase__setshowalltags)|Displays glyphs to show the location of all tags in a document.|  
|[CHtmlEditCtrlBase::SetShowAreaTags](#chtmleditctrlbase__setshowareatags)|Displays a glyph for all the area tags.|  
|[CHtmlEditCtrlBase::SetShowBRTags](#chtmleditctrlbase__setshowbrtags)|Displays a glyph for all the br tags.|  
|[CHtmlEditCtrlBase::SetShowCommentTags](#chtmleditctrlbase__setshowcommenttags)|Displays a glyph for all the comment tags.|  
|[CHtmlEditCtrlBase::SetShowMiscTags](#chtmleditctrlbase__setshowmisctags)|Displays all the tags shown in Microsoft Internet Explorer 4.0.|  
|[CHtmlEditCtrlBase::SetShowScriptTags](#chtmleditctrlbase__setshowscripttags)|Displays a glyph for all the script tags.|  
|[CHtmlEditCtrlBase::SetShowStyleTags](#chtmleditctrlbase__setshowstyletags)|Displays a glyph for all the style tags.|  
|[CHtmlEditCtrlBase::SetShowUnknownTags](#chtmleditctrlbase__setshowunknowntags)|Displays a glyph for all the unknown tags.|  
|[CHtmlEditCtrlBase::TextArea](#chtmleditctrlbase__textarea)|Overwrites a multiline text input control on the current selection.|  
|[CHtmlEditCtrlBase::TextBox](#chtmleditctrlbase__textbox)|Overwrites a text control on the current selection.|  
|[CHtmlEditCtrlBase::UnBookmark](#chtmleditctrlbase__unbookmark)|Removes any bookmark from the current selection.|  
|[CHtmlEditCtrlBase::Underline](#chtmleditctrlbase__underline)|Toggles the current selection between underlined and not underlined.|  
|[CHtmlEditCtrlBase::Unlink](#chtmleditctrlbase__unlink)|Removes any hyperlink from the current selection.|  
|[CHtmlEditCtrlBase::UnorderList](#chtmleditctrlbase__unorderlist)|Toggles the current selection between an ordered list and a normal format block.|  
  
#### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 The name of the derived class.  
  
## Remarks  
 **CHtmlEditCtrlBase** provides member functions for the WebBrowser's HTML editing commands, such as [Bold](#chtmleditctrlbase__bold). (Alternately, you can call [ExecCommand](#chtmleditctrlbase__execcommand) to execute the **IDM_BOLD** command.)  
  
 **CHtmlEditCtrlBase** is not intended to stand on its own. It is designed to be a base class for derived classes that expose the HTML editing functionality of the WebBrowser (see [CHtmlEditCtrl](../vs140/chtmleditctrl-class.md) and [CHtmlEditView](../vs140/chtmleditview-class.md)).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxhtml.h  
  
##  \<a name="chtmleditctrlbase__addtoglyphtable">\</a>  CHtmlEditCtrlBase::AddToGlyphTable  
 Adds an entry to the glyph table, which specifies images to display for specific tags in design mode.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The tag name (for example, "P" or "table").  
  
 *szImgUrl*  
 The image URL.  
  
 *nTagType*  
 Tag type: 0 means the image is for the opening tag only. 1 means the image is for the closing tag only. 2 means the image is for both the opening and closing tags. Single tags such as br and comment must be added with the tag type set to 0.  
  
 *nAlignment*  
 Alignment (rectangular elements only): This parameter indicates that the image is for an element with an alignment attribute. Left = 0, center = 1, right = 2, and undefined = 3. Left, right, or center attributes must be explicitly set on the element.  
  
 *nPosInfo*  
 Positioning information. Determines what cascading style sheets (CSS) positioning value the glyph applies to, where static positioning = 0, absolute positioning = 1, relative positioning = 2, and all = 3. This field enables you to specify one glyph for a tag when it is not positioned and another glyph to show an anchor point when the tag is positioned.  
  
 *nDirection*  
 The direction. This parameter specifies the image for a tag based on the reading order of the current language. 0 specifies left to right, 1 specifies right to left, 2 specifies top to bottom, 3 specifies bottom to top, and 4 specifies all. You normally set this field to 4.  
  
 *nImgWidth*  
 The image width in pixels.  
  
 *nImgHeight*  
 The image height in pixels.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information on the parameters, see "Glyph Table String Format" in                         [Using Editing Glyphs](https://msdn.microsoft.com/en-us/library/aa969614.aspx).  
  
 This method sends the                         [IDM_ADDTOGLYPHTABLE command ID](https://msdn.microsoft.com/en-us/library/aa769891.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__bold">\</a>  CHtmlEditCtrlBase::Bold  
 Toggles the bold state of the selected text.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BOLD command ID](https://msdn.microsoft.com/en-us/library/aa769861.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__button">\</a>  CHtmlEditCtrlBase::Button  
 Overwrites a button control on the current selection.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The ID of the button control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BUTTON command ID](https://msdn.microsoft.com/en-us/library/aa769966.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__checkbox">\</a>  CHtmlEditCtrlBase::CheckBox  
 Overwrites a check box control on the current selection.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The ID of the check box control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_CHECKBOX command ID](https://msdn.microsoft.com/en-us/library/aa769972.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__clearselection">\</a>  CHtmlEditCtrlBase::ClearSelection  
 Clears the current selection.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_CLEARSELECTION command ID](https://msdn.microsoft.com/en-us/library/aa770038.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__copy">\</a>  CHtmlEditCtrlBase::Copy  
 Copies the current selection to the clipboard.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_COPY command ID](https://msdn.microsoft.com/en-us/library/aa769872.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__cut">\</a>  CHtmlEditCtrlBase::Cut  
 Copies the current selection to the clipboard and then deletes it.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_CUT command ID](https://msdn.microsoft.com/en-us/library/aa769875.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__delete">\</a>  CHtmlEditCtrlBase::Delete  
 Deletes the current selection.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_DELETE command ID](https://msdn.microsoft.com/en-us/library/aa769876.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__dropdownbox">\</a>  CHtmlEditCtrlBase::DropDownBox  
 Overwrites a drop-down selection control on the current selection.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 The ID of the drop-down selection control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_DROPDOWNBOX command ID](https://msdn.microsoft.com/en-us/library/aa769984.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__emptyglyphtable">\</a>  CHtmlEditCtrlBase::EmptyGlyphTable  
 Removes all entries from the glyph table, which hides all images displayed for tags in design mode.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_EMPTYGLYPHTABLE command ID](https://msdn.microsoft.com/en-us/library/aa769907.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__execcommand">\</a>  CHtmlEditCtrlBase::ExecCommand  
 Executes a command.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The command ID to be executed. For a list, see                                 [MSHTML Command Identifiers](https://msdn.microsoft.com/en-us/library/aa741315.aspx).  
  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 Values taken from the                                 [OLECMDEXECOPT](http://msdn.microsoft.com/library/windows/desktop/ms683930) enumeration, which describe how the object should execute the command.  
  
 *pInVar*  
 The input arguments.  
  
 *pOutVar*  
 The command output.  
  
 *pGuid*  
 The GUID of the command group.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method provides the functionality of                         [IOleCommandTarget::Exec](http://msdn.microsoft.com/library/windows/desktop/ms690300).  
  
##  \<a name="chtmleditctrlbase__font">\</a>  CHtmlEditCtrlBase::Font  
 Opens a font dialog box to enable the user to change the text color, font, and font size of the current selection.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_FONT command ID](https://msdn.microsoft.com/en-us/library/aa769913.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getabsoluteposition">\</a>  CHtmlEditCtrlBase::GetAbsolutePosition  
 Returns whether an element's position property is "absolute."  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 True if the element's position property is set to "absolute."  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_ABSOLUTE_POSITION Command ID](https://msdn.microsoft.com/en-us/library/aa769889.aspx).  
  
##  \<a name="chtmleditctrlbase__getbackcolor">\</a>  CHtmlEditCtrlBase::GetBackColor  
 Retrieves the background color of the current selection.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The background color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BACKCOLOR Command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getblockformat">\</a>  CHtmlEditCtrlBase::GetBlockFormat  
 Retrieves the current block format tag.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 *strFormat*  
 The current block format tag.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BLOCKFMT command ID](https://msdn.microsoft.com/en-us/library/aa769883.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getblockformatnames">\</a>  CHtmlEditCtrlBase::GetBlockFormatNames  
 Retrieves the strings corresponding to the available block format tags.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 *sa*  
 The available block format tags, as an array of strings.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_GETBLOCKFMTS command ID](https://msdn.microsoft.com/en-us/library/aa769884.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getbookmark">\</a>  CHtmlEditCtrlBase::GetBookMark  
 Retrieves the name of a bookmark anchor.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *strAnchor*  
 The name of a bookmark anchor.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_BOOKMARK Command ID](https://msdn.microsoft.com/en-us/library/aa769873.aspx).  
  
##  \<a name="chtmleditctrlbase__getdocument">\</a>  CHtmlEditCtrlBase::GetDocument  
 Retrieves the document object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 The document object.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__getdocumenthtml">\</a>  CHtmlEditCtrlBase::GetDocumentHTML  
 Retrieves the HTML of the current document.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The HTML.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__getdocumenttitle">\</a>  CHtmlEditCtrlBase::GetDocumentTitle  
 Retrieves the document's title.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *szTitle*  
 The document's title.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__getevent">\</a>  CHtmlEditCtrlBase::GetEvent  
 Retrieves an interface pointer to the event object that contains information relevant to the most recent event.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The event object.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__geteventsrcelement">\</a>  CHtmlEditCtrlBase::GetEventSrcElement  
 Retrieves the object that fired the event.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 *ppSrcElement*  
 The element that fired the event.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__getfontface">\</a>  CHtmlEditCtrlBase::GetFontFace  
 Retrieves the font name for the current selection.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The font name.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 If the current selection uses more than one font, <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> will be an empty string.  
  
 This method sends the                         [IDM_FONTNAME command ID](https://msdn.microsoft.com/en-us/library/aa769880.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getfontsize">\</a>  CHtmlEditCtrlBase::GetFontSize  
 Retrieves the font size for the current selection.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 The font size.  
  
### Return Value  
 Returns the HTML font size (1-7). Returns 0 if the selection contains multiple font sizes.  
  
### Remarks  
 This method sends the                         [IDM_FONTSIZE command ID](https://msdn.microsoft.com/en-us/library/aa769881.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getforecolor">\</a>  CHtmlEditCtrlBase::GetForeColor  
 Retrieves the foreground (text) color of the current selection.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The foreground color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_FORECOLOR Command ID](https://msdn.microsoft.com/en-us/library/aa769882.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getframezone">\</a>  CHtmlEditCtrlBase::GetFrameZone  
 Returns the security zone of the current page in the web browser.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 *nZone*  
 The security zone.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_GETFRAMEZONE command ID](https://msdn.microsoft.com/en-us/library/aa769916.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__getisdirty">\</a>  CHtmlEditCtrlBase::GetIsDirty  
 Indicates whether the HTML document has changed.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 Indicates whether the document has changed. <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> returns an <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> from                         [IPersistStorage::IsDirty](http://msdn.microsoft.com/library/windows/desktop/ms683910).  
  
##  \<a name="chtmleditctrlbase__getshowalignedsitetags">\</a>  CHtmlEditCtrlBase::GetShowAlignedSiteTags  
 Returns whether a glyph is displayed for all elements that have a **styleFloat** property.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 True if a glyph is displayed for all elements that have a **styleFloat** property; false if no glyph is displayed.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWALIGNEDSITETAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769947.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowalltags">\</a>  CHtmlEditCtrlBase::GetShowAllTags  
 Returns whether the WebBrowser displays glyphs to show the location of all tags in a document.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 True if the WebBrowser displays glyphs to show the location of all tags in a document; false if it does not.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWALLTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769948.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowareatags">\</a>  CHtmlEditCtrlBase::GetShowAreaTags  
 Retrieves whether the WebBrowser displays a glyph for area tags.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 True if the WebBrowser displays a glyph for area tags, false if it does not.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWAREATAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769949.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowbrtags">\</a>  CHtmlEditCtrlBase::GetShowBRTags  
 Retrieves whether the WebBrowser displays a glyph for br tags.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 True if the WebBrowser displays a glyph for br tags, false if it doesn't.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWWBRTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769956.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowcommenttags">\</a>  CHtmlEditCtrlBase::GetShowCommentTags  
 Retrieves whether the WebBrowser displays a glyph for comment tags.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 True if the WebBrowser displays a glyph for comment tags, false if it doesn't.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWCOMMENTTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769950.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowmisctags">\</a>  CHtmlEditCtrlBase::GetShowMiscTags  
 Retrieves whether the WebBrowser displays all the tags shown in Microsoft Internet Explorer 4.0.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 True if the WebBrowser displays all the tags shown in Microsoft Internet Explorer 4.0, false if it does not.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWMISCTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769952.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowscripttags">\</a>  CHtmlEditCtrlBase::GetShowScriptTags  
 Retrieves whether the WebBrowser displays a glyph for all the script tags.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 True if the WebBrowser displays a glyph for all the script tags, false if it does not.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWSCRIPTTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769953.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowstyletags">\</a>  CHtmlEditCtrlBase::GetShowStyleTags  
 Retrieves whether the WebBrowser displays a glyph for all the style tags.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 True if the WebBrowser displays a glyph for all the style tags, false if it does not  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWSTYLETAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769954.aspx).  
  
##  \<a name="chtmleditctrlbase__getshowunknowntags">\</a>  CHtmlEditCtrlBase::GetShowUnknownTags  
 Retrieves whether the WebBrowser displays a glyph for all unknown tags.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 True if the WebBrowser displays a glyph for all unknown tags, false if it does not.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 For more information, see                         [IDM_SHOWUNKNOWNTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769955.aspx).  
  
##  \<a name="chtmleditctrlbase__horizontalline">\</a>  CHtmlEditCtrlBase::HorizontalLine  
 Overwrites a horizontal line on the current selection.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 *szID*  
 The ID for the horizontal line.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_HORIZONTALLINE command ID](https://msdn.microsoft.com/en-us/library/aa769968.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__hyperlink">\</a>  CHtmlEditCtrlBase::HyperLink  
 Inserts a hyperlink on the current selection.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The hyperlink URL.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_HYPERLINK command ID](https://msdn.microsoft.com/en-us/library/aa769874.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__ie50paste">\</a>  CHtmlEditCtrlBase::IE50Paste  
 Performs a paste operation that's compatible with Internet Explorer 5.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The string to paste.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_IE50_PASTE command ID](https://msdn.microsoft.com/en-us/library/aa769922.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__iframe">\</a>  CHtmlEditCtrlBase::Iframe  
 Overwrites an inline frame on the current selection.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The ID for the inline frame.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_IFRAME command ID](https://msdn.microsoft.com/en-us/library/aa769969.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__image">\</a>  CHtmlEditCtrlBase::Image  
 Overwrites an image on the current selection.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The path and file name of the image to be inserted.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_IMAGE command ID](https://msdn.microsoft.com/en-us/library/aa769970.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__indent">\</a>  CHtmlEditCtrlBase::Indent  
 Increases the indent of the selected text by one indentation increment.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INDENT command ID](https://msdn.microsoft.com/en-us/library/aa769963.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insfieldset">\</a>  CHtmlEditCtrlBase::InsFieldSet  
 Overwrites a box on the current selection.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The ID for the box.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSFIELDSET command ID](https://msdn.microsoft.com/en-us/library/aa769967.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputbutton">\</a>  CHtmlEditCtrlBase::InsInputButton  
 Overwrites a button control on the current selection.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The ID for the button control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTBUTTON command ID](https://msdn.microsoft.com/en-us/library/aa769971.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputhidden">\</a>  CHtmlEditCtrlBase::InsInputHidden  
 Inserts a hidden control on the current selection.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The ID for the hidden control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTHIDDEN command ID](https://msdn.microsoft.com/en-us/library/aa769974.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputimage">\</a>  CHtmlEditCtrlBase::InsInputImage  
 Overwrites an image control on the current selection.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 The ID for the image control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTIMAGE command ID](https://msdn.microsoft.com/en-us/library/aa769975.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputpassword">\</a>  CHtmlEditCtrlBase::InsInputPassword  
 Overwrites a password control on the current selection.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The ID for the password control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTPASSWORD command ID](https://msdn.microsoft.com/en-us/library/aa769976.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputreset">\</a>  CHtmlEditCtrlBase::InsInputReset  
 Overwrites a reset control on the current selection.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 The ID for the reset control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTRESET command ID](https://msdn.microsoft.com/en-us/library/aa769978.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputsubmit">\</a>  CHtmlEditCtrlBase::InsInputSubmit  
 Overwrites a submit control on the current selection.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 The ID for the submit control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTSUBMIT command ID](https://msdn.microsoft.com/en-us/library/aa769979.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__insinputupload">\</a>  CHtmlEditCtrlBase::InsInputUpload  
 Overwrites a file upload control on the current selection.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 The ID for the file upload control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_INSINPUTUPLOAD command ID](https://msdn.microsoft.com/en-us/library/aa769973.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__is1delement">\</a>  CHtmlEditCtrlBase::Is1DElement  
 Determines if an element is statically positioned.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 True if the element is statically positioned, false otherwise.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_1D_ELEMENT command ID](https://msdn.microsoft.com/en-us/library/aa769885.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__is2delement">\</a>  CHtmlEditCtrlBase::Is2DElement  
 Determines if an element is absolutely positioned.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 True if the element is absolutely positioned, false otherwise.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_2D_ELEMENT command ID](https://msdn.microsoft.com/en-us/library/aa769886.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__italic">\</a>  CHtmlEditCtrlBase::Italic  
 Toggles the current selection between italic and nonitalic.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_ITALIC command ID](https://msdn.microsoft.com/en-us/library/aa769988.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__justifycenter">\</a>  CHtmlEditCtrlBase::JustifyCenter  
 Centers the format block in which the current selection is located.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_JUSTIFYCENTER command ID](https://msdn.microsoft.com/en-us/library/aa769989.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__justifyleft">\</a>  CHtmlEditCtrlBase::JustifyLeft  
 Left-justifies the format block in which the current selection is located.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_JUSTIFYLEFT command ID](https://msdn.microsoft.com/en-us/library/aa770011.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__justifyright">\</a>  CHtmlEditCtrlBase::JustifyRight  
 Right-justifies the format block in which the current selection is located.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_JUSTIFYRIGHT command ID](https://msdn.microsoft.com/en-us/library/aa770013.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__listbox">\</a>  CHtmlEditCtrlBase::ListBox  
 Overwrites a list box selection control on the current selection.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 The ID for the list box control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_LISTBOX command ID](https://msdn.microsoft.com/en-us/library/aa769985.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__marquee">\</a>  CHtmlEditCtrlBase::Marquee  
 Overwrites an empty marquee on the current selection.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 The ID for the marquee.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_MARQUEE command ID](https://msdn.microsoft.com/en-us/library/aa769981.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__newdocument">\</a>  CHtmlEditCtrlBase::NewDocument  
 Creates a new document.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__orderlist">\</a>  CHtmlEditCtrlBase::OrderList  
 Toggles the current selection between an ordered list and a normal format block.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The ID for the ordered list.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_ORDERLIST command ID](https://msdn.microsoft.com/en-us/library/aa769982.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__outdent">\</a>  CHtmlEditCtrlBase::Outdent  
 Decreases by one increment the indentation of the format block in which the current selection is located.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_OUTDENT command ID](https://msdn.microsoft.com/en-us/library/aa770015.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__paragraph">\</a>  CHtmlEditCtrlBase::Paragraph  
 Overwrites a line break on the current selection.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The ID for the paragraph.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_PARAGRAPH command ID](https://msdn.microsoft.com/en-us/library/aa769983.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__paste">\</a>  CHtmlEditCtrlBase::Paste  
 Overwrites the contents of the clipboard on the current selection.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_PASTE command ID](https://msdn.microsoft.com/en-us/library/aa770017.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__printdocument">\</a>  CHtmlEditCtrlBase::PrintDocument  
 Prints the current document.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Path to a print template; if none is specified, the default print template is used.  
  
 *bShowPrintDialog*  
 If true, shows the Print dialog.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_PRINT command ID](https://msdn.microsoft.com/en-us/library/aa769937.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__printpreview">\</a>  CHtmlEditCtrlBase::PrintPreview  
 Opens the Print Preview window for the current document using either the default print preview template or a custom template.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Path to a print template.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_PRINTPREVIEW command ID](https://msdn.microsoft.com/en-us/library/aa769938.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__querystatus">\</a>  CHtmlEditCtrlBase::QueryStatus  
 Call this method to query the status of commands.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The command ID. Command identifiers are taken from the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>command group. These commands are defined in Mshtmcid.h. You can also find the list online at                                 [MSHTML Command Identifiers](http://go.microsoft.com/fwlink/?LinkId=149220).  
  
### Return Value  
 Returns an                         [OLECMDF](http://msdn.microsoft.com/library/windows/desktop/ms695237) indicating the status for <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>, or 0 on failure.  
  
##  \<a name="chtmleditctrlbase__radiobutton">\</a>  CHtmlEditCtrlBase::RadioButton  
 Overwrites a radio control on the current selection.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 The ID of the radio button.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_RADIOBUTTON command ID](https://msdn.microsoft.com/en-us/library/aa769977.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__refreshdocument">\</a>  CHtmlEditCtrlBase::RefreshDocument  
 Refreshes the current document.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_REFRESH Command ID](https://msdn.microsoft.com/en-us/library/aa770020.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__removeformat">\</a>  CHtmlEditCtrlBase::RemoveFormat  
 Removes the formatting tags from the current selection.  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_REMOVEFORMAT command ID](https://msdn.microsoft.com/en-us/library/aa770021.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__saveas">\</a>  CHtmlEditCtrlBase::SaveAs  
 Saves the current Web page to a file.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 The path and file name to which to save the Web page.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_SAVEAS command ID](https://msdn.microsoft.com/en-us/library/aa770024.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__selectall">\</a>  CHtmlEditCtrlBase::SelectAll  
 Selects the entire document.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_SELECTALL command ID](https://msdn.microsoft.com/en-us/library/aa770025.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__set2dposition">\</a>  CHtmlEditCtrlBase::Set2DPosition  
 Allows absolutely positioned elements to be moved by dragging.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 If true, absolutely positioned elements can be moved by dragging.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_2D_POSITION command ID](https://msdn.microsoft.com/en-us/library/aa769887.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setabsoluteposition">\</a>  CHtmlEditCtrlBase::SetAbsolutePosition  
 Sets an element's position property to "absolute" or "static."  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 If true, the element's position property is "absolute"; if false, it is "static."  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_ABSOLUTE_POSITION command ID](https://msdn.microsoft.com/en-us/library/aa769889.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setatomicselection">\</a>  CHtmlEditCtrlBase::SetAtomicSelection  
 Set atomic selection mode.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
 If true, any element that has an ATOMICSELECTION attribute set to TRUE will be selectable only as a unit.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_ATOMICSELECTION command ID](https://msdn.microsoft.com/en-us/library/aa769892.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setautourldetectmode">\</a>  CHtmlEditCtrlBase::SetAutoURLDetectMode  
 Turns automatic URL detection on and off.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 If true, automatic URL detection is enabled.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_AUTOURLDETECT_MODE command ID](https://msdn.microsoft.com/en-us/library/aa769893.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setbackcolor">\</a>  CHtmlEditCtrlBase::SetBackColor  
 Sets the background color of the current selection.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 The color. See <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> in                                 [IDM_BACKCOLOR Command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx).  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The color. See <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> in                                 [IDM_BACKCOLOR Command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx).  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BACKCOLOR_ command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setblockformat">\</a>  CHtmlEditCtrlBase::SetBlockFormat  
 Sets the current block format tag.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 The format tag.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BLOCKFMT_command ID](https://msdn.microsoft.com/en-us/library/aa769883.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setbookmark">\</a>  CHtmlEditCtrlBase::SetBookMark  
 Creates a bookmark anchor for the current selection or insertion point.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 *szAnchorName*  
 The anchor name.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_BOOKMARK command ID](https://msdn.microsoft.com/en-us/library/aa769873.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setcsseditinglevel">\</a>  CHtmlEditCtrlBase::SetCSSEditingLevel  
 Selects which CSS level (CSS1 or CSS2) the editor will support, if any.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 The CSS level. Pass 0 if you do not want CSS support.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_CSSEDITING_LEVEL command ID](https://msdn.microsoft.com/en-us/library/aa769903.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setdefaultcomposesettings">\</a>  CHtmlEditCtrlBase::SetDefaultComposeSettings  
 Call this method to set the default compose settings.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Parameters  
 *szFontName*  
 The font name.  
  
 *nFontSize*  
 The font size.  
  
 *crFontColor*  
 The font color.  
  
 *crFontBgColor*  
 The font background color.  
  
 *bBold*  
 Pass true for bold text.  
  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Pass true for italic text.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Pass true for underlined text.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_COMPOSESETTINGS command ID](https://msdn.microsoft.com/en-us/library/aa769901.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setdesignmode">\</a>  CHtmlEditCtrlBase::SetDesignMode  
 Set design mode.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 If true, turns design mode on.  
  
### Return Value  
 Returns TRUE on success, FALSE on failure.  
  
##  \<a name="chtmleditctrlbase__setdisableeditfocusui">\</a>  CHtmlEditCtrlBase::SetDisableEditFocusUI  
 Disables the hatched border and handles around an element that has edit focus.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 If true, disables the hatched border and handles around a site selectable element when the element has "edit focus" in design mode; that is, when the text or contents of the element can be edited.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM_DISABLE_EDITFOCUS_UI command ID](https://msdn.microsoft.com/en-us/library/aa769905.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setdocumenthtml">\</a>  CHtmlEditCtrlBase::SetDocumentHTML  
 Sets the HTML of the current document.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 The HTML.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
##  \<a name="chtmleditctrlbase__setfontface">\</a>  CHtmlEditCtrlBase::SetFontFace  
 Sets the font for the current selection.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The font name.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM FONTNAME Command ID](https://msdn.microsoft.com/en-us/library/aa769880.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setfontsize">\</a>  CHtmlEditCtrlBase::SetFontSize  
 Sets the font size for the current selection.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The HTML font size (1-7). A value of 0 sets the font size to 1.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM FONTSIZE command ID](https://msdn.microsoft.com/en-us/library/aa769881.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setforecolor">\</a>  CHtmlEditCtrlBase::SetForeColor  
 Sets the foreground (text) color of the current selection.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 The color.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The color.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM FORECOLOR command ID](https://msdn.microsoft.com/en-us/library/aa769882.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setie5pastemode">\</a>  CHtmlEditCtrlBase::SetIE5PasteMode  
 Sets the paste operation to be compatible with Microsoft Internet Explorer 5.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 If true, all paste operations are compatible with Internet Explorer 5; if false, paste operations are compatible with Internet Explorer 5.5.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM IE50_PASTE_MODE command ID](https://msdn.microsoft.com/en-us/library/aa769923.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setliveresize">\</a>  CHtmlEditCtrlBase::SetLiveResize  
 Causes the WebBrowser to update an element's appearance continuously during a resizing or moving operation, rather than updating only at the completion of the move or resize.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 If true, causes the WebBrowser to update an element's appearance continuously during a resizing or moving operation; if false, it updates only at the completion of the move or resize.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM LIVERESIZE command ID](https://msdn.microsoft.com/en-us/library/aa769928.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setmultiselect">\</a>  CHtmlEditCtrlBase::SetMultiSelect  
 Enables multiple selection.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 If true, allows for the selection of more than one site-selectable element at a time when the user holds down the SHIFT or CTRL keys.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM MULTIPLESELECTION command ID](https://msdn.microsoft.com/en-us/library/aa769929.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setoverridecursor">\</a>  CHtmlEditCtrlBase::SetOverrideCursor  
 Commands the WebBrowser never to change the mouse pointer.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 If true, the WebBrowser will not change the mouse pointer.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM OVERRIDE_CURSOR command ID](https://msdn.microsoft.com/en-us/library/aa769932.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setoverwritemode">\</a>  CHtmlEditCtrlBase::SetOverwriteMode  
 Toggles the text-entry mode between insert and overwrite.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 If true, text-entry mode is overwrite; if false, text-entry mode is insert.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM OVERWRITE command ID](https://msdn.microsoft.com/en-us/library/aa770016.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setrespectvisindesign">\</a>  CHtmlEditCtrlBase::SetRespectVisInDesign  
 Hides invisible elements in design mode.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
 If true, any elements that have a visibility set to "hidden" or display property set to "none" will not be shown in both design mode and browse mode; if false, those elements will be displayed only in browse mode.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM RESPECTVISIBILITY_INDESIGN command ID](https://msdn.microsoft.com/en-us/library/aa770023.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowalignedsitetags">\</a>  CHtmlEditCtrlBase::SetShowAlignedSiteTags  
 Displays a glyph for all elements that have a **styleFloat** property.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 If true, displays a glyph for all elements that have a **styleFloat** property.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWALIGNEDSITETAGS command ID](https://msdn.microsoft.com/en-us/library/aa769947.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowalltags">\</a>  CHtmlEditCtrlBase::SetShowAllTags  
 Displays glyphs to show the location of all tags in a document.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 If true, displays glyphs to show the location of all tags in a document.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWALLTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769948.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowareatags">\</a>  CHtmlEditCtrlBase::SetShowAreaTags  
 Displays a glyph for all the area tags.  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the area tags.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWAREATAGS command ID](https://msdn.microsoft.com/en-us/library/aa769949.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowbrtags">\</a>  CHtmlEditCtrlBase::SetShowBRTags  
 Displays a glyph for all the br tags.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the br tags.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWWBRTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769956.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowcommenttags">\</a>  CHtmlEditCtrlBase::SetShowCommentTags  
 Displays a glyph for all the comment tags.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the comment tags.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWCOMMENTTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769950.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowmisctags">\</a>  CHtmlEditCtrlBase::SetShowMiscTags  
 Displays all the tags shown in Microsoft Internet Explorer 4.0.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 If true, displays all the tags shown in Microsoft Internet Explorer 4.0.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWMISCTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769952.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowscripttags">\</a>  CHtmlEditCtrlBase::SetShowScriptTags  
 Displays a glyph for all the script tags.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the script tags.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWSCRIPTTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769953.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowstyletags">\</a>  CHtmlEditCtrlBase::SetShowStyleTags  
 Displays a glyph for all the style tags.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the style tags.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWSTYLETAGS command ID](https://msdn.microsoft.com/en-us/library/aa769954.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__setshowunknowntags">\</a>  CHtmlEditCtrlBase::SetShowUnknownTags  
 Displays a glyph for all the unknown tags.  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 If true, displays a glyph for all the unknown tags.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM SHOWUNKNOWNTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769955.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__textarea">\</a>  CHtmlEditCtrlBase::TextArea  
 Overwrites a multiline text input control on the current selection.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The ID of the multiline text input control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM TEXTAREA command ID](https://msdn.microsoft.com/en-us/library/aa769986.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__textbox">\</a>  CHtmlEditCtrlBase::TextBox  
 Overwrites a text control on the current selection.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 The ID of the text control.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM TEXTBOX command ID](https://msdn.microsoft.com/en-us/library/aa769980.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__unbookmark">\</a>  CHtmlEditCtrlBase::UnBookmark  
 Removes any bookmark from the current selection.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM UNBOOKMARK command ID](https://msdn.microsoft.com/en-us/library/aa770034.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__underline">\</a>  CHtmlEditCtrlBase::Underline  
 Toggles the current selection between underlined and not underlined.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM UNDERLINE command ID](https://msdn.microsoft.com/en-us/library/aa770035.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__unlink">\</a>  CHtmlEditCtrlBase::Unlink  
 Removes any hyperlink from the current selection.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM UNLINK command ID](https://msdn.microsoft.com/en-us/library/aa770037.aspx) to the WebBrowser control.  
  
##  \<a name="chtmleditctrlbase__unorderlist">\</a>  CHtmlEditCtrlBase::UnorderList  
 Toggles the current selection between an ordered list and a normal format block.  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The ID of the unordered list.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 This method sends the                         [IDM UNORDERLIST command ID](https://msdn.microsoft.com/en-us/library/aa769987.aspx) to the WebBrowser control.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [HTMLEdit Sample](../vs140/visual-c---samples.md)