---
title: "CRichEditView Class"
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
  - "CRichEditView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document/view architecture, rich edit controls"
  - "OLE containers, rich edit"
  - "rich edit controls, OLE container"
  - "CRichEditView class"
ms.assetid: bd576b10-4cc0-4050-8f76-e1a0548411e4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView Class
With [CRichEditDoc](../vs140/cricheditdoc-class.md) and [CRichEditCntrItem](../vs140/cricheditcntritem-class.md), provides the functionality of the rich edit control within the context of MFC's document view architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditView::CRichEditView](#cricheditview__cricheditview)|Constructs a <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditView::AdjustDialogPosition](#cricheditview__adjustdialogposition)|Moves a dialog box so that it doesn't obscure the current selection.|  
|[CRichEditView::CanPaste](#cricheditview__canpaste)|Tells whether the Clipboard contains data that can be pasted into the rich edit view.|  
|[CRichEditView::DoPaste](#cricheditview__dopaste)|Pastes an OLE item into this rich edit view.|  
|[CRichEditView::FindText](#cricheditview__findtext)|Finds the specified text, invoking the wait cursor.|  
|[CRichEditView::FindTextSimple](#cricheditview__findtextsimple)|Finds the specified text.|  
|[CRichEditView::GetCharFormatSelection](#cricheditview__getcharformatselection)|Retrieves the character formatting attributes for the current selection.|  
|[CRichEditView::GetDocument](#cricheditview__getdocument)|Retrieves a pointer to the related [CRichEditDoc](../vs140/cricheditdoc-class.md).|  
|[CRichEditView::GetInPlaceActiveItem](#cricheditview__getinplaceactiveitem)|Retrieves the OLE item that is currently in-place active in the rich edit view.|  
|[CRichEditView::GetMargins](#cricheditview__getmargins)|Retrieves the margins for this rich edit view.|  
|[CRichEditView::GetPageRect](#cricheditview__getpagerect)|Retrieves the page rectangle for this rich edit view.|  
|[CRichEditView::GetPaperSize](#cricheditview__getpapersize)|Retrieves the paper size for this rich edit view.|  
|[CRichEditView::GetParaFormatSelection](#cricheditview__getparaformatselection)|Retrieves the paragraph formatting attributes for the current selection.|  
|[CRichEditView::GetPrintRect](#cricheditview__getprintrect)|Retrieves the print rectangle for this rich edit view.|  
|[CRichEditView::GetPrintWidth](#cricheditview__getprintwidth)|Retrieves the print width for this rich edit view.|  
|[CRichEditView::GetRichEditCtrl](#cricheditview__getricheditctrl)|Retrieves the rich edit control.|  
|[CRichEditView::GetSelectedItem](#cricheditview__getselecteditem)|Retrieves the selected item from the rich edit view.|  
|[CRichEditView::GetTextLength](#cricheditview__gettextlength)|Retrieves the length of the text in the rich edit view.|  
|[CRichEditView::GetTextLengthEx](#cricheditview__gettextlengthex)|Retrieves the number of characters or bytes in the rich edit view. Expanded flag list for method of determining the length.|  
|[CRichEditView::InsertFileAsObject](#cricheditview__insertfileasobject)|Inserts a file as an OLE item.|  
|[CRichEditView::InsertItem](#cricheditview__insertitem)|Inserts a new item as an OLE item.|  
|[CRichEditView::IsRichEditFormat](#cricheditview__isricheditformat)|Tells whether the Clipboard contains data in a rich edit or text format.|  
|[CRichEditView::OnCharEffect](#cricheditview__onchareffect)|Toggles the character formatting for the current selection.|  
|[CRichEditView::OnParaAlign](#cricheditview__onparaalign)|Changes the alignment of paragraphs.|  
|[CRichEditView::OnUpdateCharEffect](#cricheditview__onupdatechareffect)|Updates the Command UI for character public member functions.|  
|[CRichEditView::OnUpdateParaAlign](#cricheditview__onupdateparaalign)|Updates the Command UI for paragraph public member functions.|  
|[CRichEditView::PrintInsideRect](#cricheditview__printinsiderect)|Formats the specified text within the given rectangle.|  
|[CRichEditView::PrintPage](#cricheditview__printpage)|Formats the specified text within the given page.|  
|[CRichEditView::SetCharFormat](#cricheditview__setcharformat)|Sets the character formatting attributes for the current selection.|  
|[CRichEditView::SetMargins](#cricheditview__setmargins)|Sets the margins for this rich edit view.|  
|[CRichEditView::SetPaperSize](#cricheditview__setpapersize)|Sets the paper size for this rich edit view.|  
|[CRichEditView::SetParaFormat](#cricheditview__setparaformat)|Sets the paragraph formatting attributes for the current selection.|  
|[CRichEditView::TextNotFound](#cricheditview__textnotfound)|Resets the internal search state of the control.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditView::GetClipboardData](#cricheditview__getclipboarddata)|Retrieves a Clipboard object for a range in this rich edit view.|  
|[CRichEditView::GetContextMenu](#cricheditview__getcontextmenu)|Retrieves a context menu to use on a right mouse-button down.|  
|[CRichEditView::IsSelected](#cricheditview__isselected)|Indicates if the given OLE item is selected or not.|  
|[CRichEditView::OnFindNext](#cricheditview__onfindnext)|Finds the next occurrence of a substring.|  
|[CRichEditView::OnInitialUpdate](#cricheditview__oninitialupdate)|Refreshes a view when it is first attached to a document.|  
|[CRichEditView::OnPasteNativeObject](#cricheditview__onpastenativeobject)|Retrieves native data from an OLE item.|  
|[CRichEditView::OnPrinterChanged](#cricheditview__onprinterchanged)|Sets the print characteristics to the given device.|  
|[CRichEditView::OnReplaceAll](#cricheditview__onreplaceall)|Replaces all occurrences of a given string with a new string.|  
|[CRichEditView::OnReplaceSel](#cricheditview__onreplacesel)|Replaces the current selection.|  
|[CRichEditView::OnTextNotFound](#cricheditview__ontextnotfound)|Handles user notification that the requested text was not found.|  
|[CRichEditView::QueryAcceptData](#cricheditview__queryacceptdata)|Queries to see about the data on the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.|  
|[CRichEditView::WrapChanged](#cricheditview__wrapchanged)|Adjusts the target output device for this rich edit view, based on the value of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRichEditView::m_nBulletIndent](#cricheditview__m_nbulletindent)|Indicates the amount of indent for bullet lists.|  
|[CRichEditView::m_nWordWrap](#cricheditview__m_nwordwrap)|Indicates the word wrap constraints.|  
  
## Remarks  
 A "rich edit control" is a window in which the user can enter and edit text. The text can be assigned character and paragraph formatting, and can include embedded OLE objects. Rich edit controls provide a programming interface for formatting text. However, an application must implement any user interface components necessary to make formatting operations available to the user.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> maintains the text and formatting characteristic of text. <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> maintains the list of OLE client items which are in the view. <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> provides container-side access to the OLE client item.  
  
 This Windows Common control (and therefore the [CRichEditCtrl](../vs140/cricheditctrl-class.md) and related classes) is available only to programs running under Windows 95/98 and Windows NT versions 3.51 and later.  
  
 For an example of using a rich edit view in an MFC application, see the [WORDPAD](../vs140/visual-c---samples.md) sample application.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CCtrlView](../vs140/cctrlview-class.md)  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxrich.h  
  
##  \<a name="cricheditview__adjustdialogposition">\</a>  CRichEditView::AdjustDialogPosition  
 Call this function to move the given dialog box so that it does not obscure the current selection.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *pDlg*  
 Pointer to a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
##  \<a name="cricheditview__canpaste">\</a>  CRichEditView::CanPaste  
 Call this function to determine if the Clipboard contains information that can be pasted into this rich edit view.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the Clipboard contains data in a format which this rich edit view can accept; otherwise, 0.  
  
##  \<a name="cricheditview__cricheditview">\</a>  CRichEditView::CRichEditView  
 Call this function to create a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cricheditview__dopaste">\</a>  CRichEditView::DoPaste  
 Call this function to paste the OLE item in <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> into this rich edit document/view.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The [COleDataObject](../vs140/coledataobject-class.md) containing the data to paste.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The desired Clipboard format.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The metafile that represents the item to be pasted.  
  
### Remarks  
 The framework calls this function as part of the default implementation of [QueryAcceptData](#cricheditview__queryacceptdata).  
  
 This function determines the type of paste based on the results of the handler for Paste Special. If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is 0, the new item uses the current iconic representation. If <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is nonzero and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> is not **NULL**, the new item uses <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> for its representation.  
  
##  \<a name="cricheditview__findtext">\</a>  CRichEditView::FindText  
 Call this function to find the specified text and set it to be the current selection.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 Contains the string to search for.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Indicates if the search is case sensitive.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Indicates if the search should match whole words only, not parts of words.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Indicates the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> text is found; otherwise 0.  
  
### Remarks  
 This function displays the wait cursor during the find operation.  
  
### Example  
 [!code[NVC_MFCDocView#151](../vs140/codesnippet/CPP/cricheditview-class_1.cpp)]  
  
##  \<a name="cricheditview__findtextsimple">\</a>  CRichEditView::FindTextSimple  
 Call this function to find the specified text and set it to be the current selection.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Contains the string to search for.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Indicates if the search is case sensitive.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Indicates if the search should match whole words only, not parts of words.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Indicates the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> text is found; otherwise 0.  
  
### Example  
  See the example for [CRichEditView::FindText](#cricheditview__findtext).  
  
##  \<a name="cricheditview__getcharformatselection">\</a>  CRichEditView::GetCharFormatSelection  
 Call this function to get the character formatting attributes of the current selection.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A                         [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure which contains the character formatting attributes of the current selection.  
  
### Remarks  
 For more information, see the                         [EM_GETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb788026) message and the                         [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#152](../vs140/codesnippet/CPP/cricheditview-class_2.cpp)]  
  
##  \<a name="cricheditview__getclipboarddata">\</a>  CRichEditView::GetClipboardData  
 The framework calls this function as part of the processing of                 [IRichEditOleCallback::GetClipboardData](http://msdn.microsoft.com/library/windows/desktop/bb774315).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 Pointer to the                                 [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure specifying the range of characters (and OLE items) to copy to the data object specified by <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Clipboard operation flag. Can be one of these values.  
  
-   **RECO_COPY** Copy to the Clipboard.  
  
-   **RECO_CUT** Cut to the Clipboard.  
  
-   **RECO_DRAG** Drag operation (drag and drop).  
  
-   **RECO_DROP** Drop operation (drag and drop).  
  
-   **RECO_PASTE** Paste from the Clipboard.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Pointer to an                                 [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) object containing the Clipboard data from the rich edit control (                                [IRichEditOle::GetClipboardData](http://msdn.microsoft.com/library/windows/desktop/bb774341)).  
  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Pointer to the pointer variable that receives the address of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object representing the range specified in the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> parameter. The value of <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is ignored if an error is returned.  
  
### Return Value  
 An <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> value reporting the success of the operation. For more information on <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, see                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If the return value indicates success, **IRichEditOleCallback::GetClipboardData** returns the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> accessed by <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>; otherwise, it returns the one accessed by <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>. Override this function to supply your own Clipboard data. The default implementation of this function returns **E_NOTIMPL**.  
  
 This is an advanced overridable.  
  
 For more information, see                         [IRichEditOle::GetClipboardData](http://msdn.microsoft.com/library/windows/desktop/bb774341),                         [IRichEditOleCallback::GetClipboardData](http://msdn.microsoft.com/library/windows/desktop/bb774315), and                         [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and see                         [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)].  
  
##  \<a name="cricheditview__getcontextmenu">\</a>  CRichEditView::GetContextMenu  
 The framework calls this function as part of the processing of                 [IRichEditOleCallback::GetContextMenu](http://msdn.microsoft.com/library/windows/desktop/bb774317).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *seltyp*  
 The selection type. The selection type values are described in the Remarks section.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 Pointer to a **OLEOBJECT** structure specifying the first selected OLE object if the selection contains one or more OLE items. If the selection contains no items, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is **NULL**. The **OLEOBJECT** structure holds a pointer to an OLE object v-table.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 Pointer to a                                 [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) structure containing the current selection.  
  
### Return Value  
 Handle to the context menu.  
  
### Remarks  
 This function is a typical part of right mouse-button down processing.  
  
 The selection type can be any combination of the following flags:  
  
-   <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> Indicates that there is no current selection.  
  
-   <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> Indicates that the current selection contains text.  
  
-   <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> Indicates that the current selection contains at least one OLE item.  
  
-   <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> Indicates that the current selection contains more than one character of text.  
  
-   <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> Indicates that the current selection contains more than one OLE object.  
  
 The default implementation returns **NULL**. This is an advanced overridable.  
  
 For more information, see                         [IRichEditOleCallback::GetContextMenu](http://msdn.microsoft.com/library/windows/desktop/bb774317) and                         [CHARRANGE](http://msdn.microsoft.com/library/windows/desktop/bb787885) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on the **OLEOBJECT** type, see the OLE Data Structures and Structure Allocation article in the                         *OLE Knowledge Base*.  
  
##  \<a name="cricheditview__getdocument">\</a>  CRichEditView::GetDocument  
 Call this function to get a pointer to the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> associated with this view.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a [CRichEditDoc](../vs140/cricheditdoc-class.md) object associated with your <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object.  
  
##  \<a name="cricheditview__getinplaceactiveitem">\</a>  CRichEditView::GetInPlaceActiveItem  
 Call this function to get the OLE item that is currently activated in place in this <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the single, in-place active [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object in this rich edit view; **NULL** if there is no OLE item currently in the in-place active state.  
  
##  \<a name="cricheditview__getmargins">\</a>  CRichEditView::GetMargins  
 Call this function to retrieve the current margins used in printing.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The margins used in printing, measured in <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>.  
  
##  \<a name="cricheditview__getpagerect">\</a>  CRichEditView::GetPageRect  
 Call this function to get the dimensions of the page used in printing.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The bounds of the page used in printing, measured in <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
### Remarks  
 This value is based on the paper size.  
  
##  \<a name="cricheditview__getpapersize">\</a>  CRichEditView::GetPaperSize  
 Call this function to retrieve the current paper size.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The size of the paper used in printing, measured in <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#153](../vs140/codesnippet/CPP/cricheditview-class_3.cpp)]  
  
##  \<a name="cricheditview__getparaformatselection">\</a>  CRichEditView::GetParaFormatSelection  
 Call this function to get the paragraph formatting attributes of the current selection.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A                         [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure which contains the paragraph formatting attributes of the current selection.  
  
### Remarks  
 For more information, see                         [EM_GETPARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774182) message and                         [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cricheditview__getprintrect">\</a>  CRichEditView::GetPrintRect  
 Call this function to retrieve the bounds of the printing area within the page rectangle.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The bounds of the image area used in printing, measured in <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#154](../vs140/codesnippet/CPP/cricheditview-class_4.cpp)]  
  
##  \<a name="cricheditview__getprintwidth">\</a>  CRichEditView::GetPrintWidth  
 Call this function to determine the width of the printing area.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The width of the printing area, measured in <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
##  \<a name="cricheditview__getricheditctrl">\</a>  CRichEditView::GetRichEditCtrl  
 Call this function to retrieve the [CRichEditCtrl](../vs140/cricheditctrl-class.md) object associated with the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object for this view.  
  
### Example  
  See the example for [CRichEditView::FindText](#cricheditview__findtext).  
  
##  \<a name="cricheditview__getselecteditem">\</a>  CRichEditView::GetSelectedItem  
 Call this function to retrieve the OLE item (a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object) currently selected in this <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object selected in the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object; **NULL** if no item is selected in this view.  
  
##  \<a name="cricheditview__gettextlength">\</a>  CRichEditView::GetTextLength  
 Call this function to retrieve the length of the text in this <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The length of the text in this <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object.  
  
##  \<a name="cricheditview__gettextlengthex">\</a>  CRichEditView::GetTextLengthEx  
 Call this member function to calculate the length of the text in this <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Value specifying the method to be used in determining the text length. This member can be one or more of the values listed in the flags member of                                 [GETTEXTLENGTHEX](http://msdn.microsoft.com/library/windows/desktop/bb787915) described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Code page for translation (CP_ACP for ANSI Code Page, 1200 for Unicode).  
  
### Return Value  
 The number of characters or bytes in the edit control. If incompatible flags were set in <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, this member function returns <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> provides additional ways of determining the length of the text. It supports the Rich Edit 2.0 functionality. For more information, see                         [About Rich Edit Controls](http://msdn.microsoft.com/library/windows/desktop/bb787873) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cricheditview__insertfileasobject">\</a>  CRichEditView::InsertFileAsObject  
 Call this function to insert the specified file (as a [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object) into a rich edit view.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 String containing the name of the file to be inserted.  
  
##  \<a name="cricheditview__insertitem">\</a>  CRichEditView::InsertItem  
 Call this function to insert a [CRichEditCntrItem](../vs140/cricheditcntritem-class.md) object into a rich edit view.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 Pointer to the item to be inserted.  
  
### Return Value  
 An <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> value indicating the success of the insertion.  
  
### Remarks  
 For more information on <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>, see                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cricheditview__isricheditformat">\</a>  CRichEditView::IsRichEditFormat  
 Call this function to determine if <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> is a Clipboard format which is text, rich text, or rich text with OLE items.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The Clipboard format of interest.  
  
### Return Value  
 Nonzero if <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is a rich edit or text Clipboard format.  
  
##  \<a name="cricheditview__isselected">\</a>  CRichEditView::IsSelected  
 Call this function to determine if the specified OLE item is currently selected in this view.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 Pointer to an object in the view.  
  
### Return Value  
 Nonzero if the object is selected; otherwise 0.  
  
### Remarks  
 Override this function if your derived view class has a different method for handling selection of OLE items.  
  
##  \<a name="cricheditview__m_nbulletindent">\</a>  CRichEditView::m_nBulletIndent  
 The indentation for bullet items in a list; by default, 720 units, which is 1/2 inch.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
##  \<a name="cricheditview__m_nwordwrap">\</a>  CRichEditView::m_nWordWrap  
 Indicates the type of word wrap for this rich edit view.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Remarks  
 One of the following values:  
  
-   <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> Indicates no automatic word wrapping.  
  
-   <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> Indicates word wrapping based on the width of the window.  
  
-   <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> Indicates word wrapping based on the characteristics of the target device.  
  
### Example  
  See the example for [CRichEditView::WrapChanged](#cricheditview__wrapchanged).  
  
##  \<a name="cricheditview__onchareffect">\</a>  CRichEditView::OnCharEffect  
 Call this function to toggle the character formatting effects for the current selection.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The character formatting effects to modify in the current selection.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The desired list of character formatting effects to toggle.  
  
### Remarks  
 Each call to this function toggles the specified formatting effects for the current selection.  
  
 For more information on the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> parameters and their potential values, see the corresponding data members of                         [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#155](../vs140/codesnippet/CPP/cricheditview-class_5.cpp)]  
  
##  \<a name="cricheditview__onfindnext">\</a>  CRichEditView::OnFindNext  
 Called by the framework when processing commands from the Find/Replace dialog box.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The string to find.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The direction to search: **TRUE** indicates down; **FALSE**, up.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 Indicates whether the search is to be case sensitive.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 Indicates whether the search is to match whole words only or not.  
  
### Remarks  
 Call this function to find text within the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>. Override this function to alter search characteristics for your derived view class.  
  
##  \<a name="cricheditview__oninitialupdate">\</a>  CRichEditView::OnInitialUpdate  
 Called by the framework after the view is first attached to the document, but before the view is initially displayed.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Remarks  
 The default implementation of this function calls the [CView::OnUpdate](../vs140/cview-class.md#cview__onupdate) member function with no hint information (that is, using the default values of 0 for the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> parameter and **NULL** for the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> parameter). Override this function to perform any one-time initialization that requires information about the document. For example, if your application has fixed-sized documents, you can use this function to initialize a view's scrolling limits based on the document size. If your application supports variable-sized documents, use <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> to update the scrolling limits every time the document changes.  
  
### Example  
  See the example for [CRichEditView::m_nWordWrap](#cricheditview__m_nwordwrap).  
  
##  \<a name="cricheditview__onpastenativeobject">\</a>  CRichEditView::OnPasteNativeObject  
 Use this function to load native data from an embedded item.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 *lpStg*  
 Pointer to an                                 [IStorage](http://msdn.microsoft.com/library/windows/desktop/aa380015) object.  
  
### Return Value  
 Nonzero if successful; otherwise, 0;  
  
### Remarks  
 Typically, you would do this by creating a [COleStreamFile](../vs140/colestreamfile-class.md) around the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> can be attached to an archive and [CObject::Serialize](../vs140/cobject-class.md#cobject__serialize) called to load the data.  
  
 This is an advanced overridable.  
  
 For more information, see                         [IStorage](http://msdn.microsoft.com/library/windows/desktop/aa380015) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cricheditview__onparaalign">\</a>  CRichEditView::OnParaAlign  
 Call this function to change the paragraph alignment for the selected paragraphs.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Desired paragraph alignment. One of the following values:  
  
-   <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> Align the paragraphs with the left margin.  
  
-   <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> Align the paragraphs with the right margin.  
  
-   <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> Center the paragraphs between the margins.  
  
### Example  
 [!code[NVC_MFCDocView#156](../vs140/codesnippet/CPP/cricheditview-class_6.cpp)]  
  
##  \<a name="cricheditview__onprinterchanged">\</a>  CRichEditView::OnPrinterChanged  
 Override this function to change characteristics for this rich edit view when the printer changes.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 A [CDC](../vs140/cdc-class.md) object for the new printer.  
  
### Remarks  
 The default implementation sets the paper size to the physical height and width for the output device (printer). If there is no device context associated with <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>, the default implementation sets the paper size to 8.5 by 11 inches.  
  
##  \<a name="cricheditview__onreplaceall">\</a>  CRichEditView::OnReplaceAll  
 Called by the framework when processing Replace All commands from the Replace dialog box.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The text to be replaced.  
  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
 The replacement text.  
  
 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 Indicates if the search is case sensitive.  
  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 Indicates if the search must select whole words or not.  
  
### Remarks  
 Call this function to replace all occurrences of some given text with another string. Override this function to alter search characteristics for this view.  
  
### Example  
  See the example for [CRichEditView::FindText](#cricheditview__findtext).  
  
##  \<a name="cricheditview__onreplacesel">\</a>  CRichEditView::OnReplaceSel  
 Called by the framework when processing Replace commands from the Replace dialog box.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The text to be replaced.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Indicates the direction of the search: **TRUE** is down; **FALSE**, up.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 Indicates if the search is case sensitive.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 Indicates if the search must select whole words or not.  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The replacement text.  
  
### Remarks  
 Call this function to replace one occurrence of some given text with another string. Override this function to alter search characteristics for this view.  
  
##  \<a name="cricheditview__ontextnotfound">\</a>  CRichEditView::OnTextNotFound  
 Called by the framework whenever a search fails.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 The text which was not found.  
  
### Remarks  
 Override this function to change the output notification from a                         [MessageBeep](http://msdn.microsoft.com/library/windows/desktop/ms680356).  
  
 For more information, see                         [MessageBeep](http://msdn.microsoft.com/library/windows/desktop/ms680356) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#157](../vs140/codesnippet/CPP/cricheditview-class_7.cpp)]  
  
##  \<a name="cricheditview__onupdatechareffect">\</a>  CRichEditView::OnUpdateCharEffect  
 The framework calls this function to update the command UI for character effect commands.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 Pointer to a [CCmdUI](../vs140/ccmdui-class.md) object.  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Indicates the character formatting mask.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 Indicates the character formatting effect.  
  
### Remarks  
 The mask <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> specifies which character formatting attributes to check. The flags <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> list the character formatting attributes to set/clear.  
  
 For more information on the <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> parameters and their potential values, see the corresponding data members of                         [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#158](../vs140/codesnippet/CPP/cricheditview-class_8.cpp)]  
  
##  \<a name="cricheditview__onupdateparaalign">\</a>  CRichEditView::OnUpdateParaAlign  
 The framework calls this function to update the command UI for paragraph effect commands.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 Pointer to a [CCmdUI](../vs140/ccmdui-class.md) object.  
  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 The paragraph alignment to check. One of the following values:  
  
-   <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> Align the paragraphs with the left margin.  
  
-   <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> Align the paragraphs with the right margin.  
  
-   <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> Center the paragraphs between the margins.  
  
### Example  
 [!code[NVC_MFCDocView#159](../vs140/codesnippet/CPP/cricheditview-class_9.cpp)]  
  
##  \<a name="cricheditview__printinsiderect">\</a>  CRichEditView::PrintInsideRect  
 Call this function to format a range of text in a rich edit control to fit within                 *rectLayout* for the device specified by <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 Pointer to a device context for the output area.  
  
 *rectLayout*  
 [RECT](../vs140/rect-structure.md) or [CRect](../vs140/crect-class.md) which defines the output area.  
  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 Zero-based index of the first character to be formatted.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 Zero-based index of the last character to be formatted.  
  
 *bOutput*  
 Indicates if the text should be rendered. If **FALSE**, the text is just measured.  
  
### Return Value  
 The index of the last character that fits in the output area plus one.  
  
### Remarks  
 Typically, this call is followed by a call to [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl-class.md#cricheditctrl__displayband) which generates the output.  
  
### Example  
  See the example for [CRichEditView::GetPaperSize](#cricheditview__getpapersize).  
  
##  \<a name="cricheditview__printpage">\</a>  CRichEditView::PrintPage  
 Call this function to format a range of text in a rich edit control for the output device specified by <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 Pointer to a device context for page output.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 Zero-based index of the first character to be formatted.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 Zero-based index of the last character to be formatted.  
  
### Return Value  
 The index of the last character that fits on the page plus one.  
  
### Remarks  
 The layout of each page is controlled by [GetPageRect](#cricheditview__getpagerect) and [GetPrintRect](#cricheditview__getprintrect). Typically, this call is followed by a call to [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl-class.md#cricheditctrl__displayband) which generates the output.  
  
 Note that margins are relative to the physical page, not the logical page. Thus, margins of zero will often clip the text since many printers have unprintable areas on the page. To avoid clipping your text, you should call [SetMargins](#cricheditview__setmargins) and set reasonable margins before printing.  
  
##  \<a name="cricheditview__queryacceptdata">\</a>  CRichEditView::QueryAcceptData  
 Called by the framework to paste an object into the rich edit.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *lpdataobj*  
 Pointer to the                                 [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) to query.  
  
 *lpcfFormat*  
 Pointer to the acceptable data format.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 Not used.  
  
 *bReally*  
 Indicates if the paste operation should continue or not.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 A handle to the metafile used for drawing the item's icon.  
  
### Return Value  
 An <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> value reporting the success of the operation.  
  
### Remarks  
 Override this function to handle different organization of COM items in your derived document class. This is an advanced overridable.  
  
 For more information on <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>, see                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) and                         [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421), respectively, in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#160](../vs140/codesnippet/CPP/cricheditview-class_10.cpp)]  
  
##  \<a name="cricheditview__setcharformat">\</a>  CRichEditView::SetCharFormat  
 Call this function to set the character formatting attributes for new text in this <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure containing the new default character formatting attributes.  
  
### Remarks  
 Only the attributes specified by the **dwMask** member of <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> are changed by this function.  
  
 For more information, see                         [EM_SETCHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774230) message and                         [CHARFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787883) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#152](../vs140/codesnippet/CPP/cricheditview-class_2.cpp)]  
  
##  \<a name="cricheditview__setmargins">\</a>  CRichEditView::SetMargins  
 Call this function to set the printing margins for this rich edit view.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 *rectMargin*  
 The new margin values for printing, measured in <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>.  
  
### Remarks  
 If [m_nWordWrap](#cricheditview__m_nwordwrap) is <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>, you should call [WrapChanged](#cricheditview__wrapchanged) after using this function to adjust printing characteristics.  
  
 Note that the margins used by [PrintPage](#cricheditview__printpage) are relative to the physical page, not the logical page. Thus, margins of zero will often clip the text since many printers have unprintable areas on the page. To avoid clipping your text, you should call use <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> to set reasonable printer margins before printing.  
  
### Example  
  See the example for [CRichEditView::GetPaperSize](#cricheditview__getpapersize).  
  
##  \<a name="cricheditview__setpapersize">\</a>  CRichEditView::SetPaperSize  
 Call this function to set the paper size for printing this rich edit view.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 *sizePaper*  
 The new paper size values for printing, measured in <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Remarks  
 If [m_nWordWrap](#cricheditview__m_nwordwrap) is <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, you should call [WrapChanged](#cricheditview__wrapchanged) after using this function to adjust printing characteristics.  
  
### Example  
 [!code[NVC_MFCDocView#161](../vs140/codesnippet/CPP/cricheditview-class_11.cpp)]  
  
##  \<a name="cricheditview__setparaformat">\</a>  CRichEditView::SetParaFormat  
 Call this function to set the paragraph formatting attributes for the current selection in this <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure containing the new default paragraph formatting attributes.  
  
### Return Value  
 Nonzero if successful; otherwise, 0.  
  
### Remarks  
 Only the attributes specified by the **dwMask** member of <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> are changed by this function.  
  
 For more information, see                         [EM_SETPARAFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb774276) message and                         [PARAFORMAT2](http://msdn.microsoft.com/library/windows/desktop/bb787942) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#162](../vs140/codesnippet/CPP/cricheditview-class_12.cpp)]  
  
##  \<a name="cricheditview__textnotfound">\</a>  CRichEditView::TextNotFound  
 Call this function to reset the internal search state of the [CRichEditView](../vs140/cricheditview-class.md) control after a failed call to [FindText](#cricheditview__findtext).  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 Contains the text string that was not found.  
  
### Remarks  
 It is recommended that this method be called immediately after failed calls to [FindText](#cricheditview__findtext) so that the internal search state of the control is properly reset.  
  
 The <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> parameter should include the same content as the string provided to [FindText](#cricheditview__findtext). After resetting the internal search state, this method will call the [OnTextNotFound](#cricheditview__ontextnotfound) method with the provided search string.  
  
### Example  
  See the example for [CRichEditView::FindText](#cricheditview__findtext).  
  
##  \<a name="cricheditview__wrapchanged">\</a>  CRichEditView::WrapChanged  
 Call this function when the printing characteristics have changed ( [SetMargins](#cricheditview__setmargins) or [SetPaperSize](#cricheditview__setpapersize)).  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Remarks  
 Override this function to modify the way the rich edit view responds to changes in [m_nWordWrap](#cricheditview__m_nwordwrap) or the printing characteristics ( [OnPrinterChanged](#cricheditview__onprinterchanged)).  
  
### Example  
 [!code[NVC_MFCDocView#163](../vs140/codesnippet/CPP/cricheditview-class_13.cpp)]  
  
## See Also  
 [MFC Sample WORDPAD](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cctrlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditDoc](../vs140/cricheditdoc-class.md)   
 [CRichEditCntrItem](../vs140/cricheditcntritem-class.md)