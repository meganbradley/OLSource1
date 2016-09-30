---
title: "CPrintDialogEx Class"
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
  - "CPrintDialogEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Print Setup dialog box"
  - "CPrintDialogEx class"
  - "Print dialog box"
ms.assetid: 1d506703-ee1c-44cc-b4ce-4e778fec26b8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx Class
Encapsulates the services provided by the Windows 2000 Print property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPrintDialogEx::CPrintDialogEx](#cprintdialogex__cprintdialogex)|Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPrintDialogEx::CreatePrinterDC](#cprintdialogex__createprinterdc)|Creates a printer device context without displaying the Print dialog box.|  
|[CPrintDialogEx::DoModal](#cprintdialogex__domodal)|Displays the dialog box and allows the user to make selections.|  
|[CPrintDialogEx::GetCopies](#cprintdialogex__getcopies)|Retrieves the number of copies requested.|  
|[CPrintDialogEx::GetDefaults](#cprintdialogex__getdefaults)|Retrieves device defaults without displaying a dialog box.|  
|[CPrintDialogEx::GetDeviceName](#cprintdialogex__getdevicename)|Retrieves the name of the currently selected printer device.|  
|[CPrintDialogEx::GetDevMode](#cprintdialogex__getdevmode)|Retrieves the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> structure.|  
|[CPrintDialogEx::GetDriverName](#cprintdialogex__getdrivername)|Retrieves the name of the system-defined printer device driver.|  
|[CPrintDialogEx::GetPortName](#cprintdialogex__getportname)|Retrieves the name of the currently selected printer port.|  
|[CPrintDialogEx::GetPrinterDC](#cprintdialogex__getprinterdc)|Retrieves a handle to the printer device context.|  
|[CPrintDialogEx::PrintAll](#cprintdialogex__printall)|Determines whether to print all pages of the document.|  
|[CPrintDialogEx::PrintCollate](#cprintdialogex__printcollate)|Determines whether collated copies are requested.|  
|[CPrintDialogEx::PrintCurrentPage](#cprintdialogex__printcurrentpage)|Determines whether to print the current page of the document.|  
|[CPrintDialogEx::PrintRange](#cprintdialogex__printrange)|Determines whether to print only a specified range of pages.|  
|[CPrintDialogEx::PrintSelection](#cprintdialogex__printselection)|Determines whether to print only the currently selected items.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPrintDialogEx::m_pdex](#cprintdialogex__m_pdex)|A structure used to customize a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 You can rely on the framework to handle many aspects of the printing process for your application. For more information about using the framework to handle printing tasks, see the article [Printing](../vs140/printing.md).  
  
 If you want your application to handle printing without the framework's involvement, you can use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class "as is" with the constructor provided, or you can derive your own dialog class from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and write a constructor to suit your needs. In either case, these dialog boxes will behave like standard MFC dialog boxes because they are derived from class <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 To use a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object, first create the object using the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> constructor. Once the dialog box has been constructed, you can set or modify any values in the [m_pdex](#cprintdialogex__m_pdex) structure to initialize the values of the dialog box's controls. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> structure is of type                 [PRINTDLGEX](http://msdn.microsoft.com/library/windows/desktop/ms646844). For more information on this structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If you do not supply your own handles in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for the **hDevMode** and **hDevNames** members, be sure to call the Windows function **GlobalFree** for these handles when you are done with the dialog box.  
  
 After initializing the dialog box controls, call the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member function to display the dialog box and allow the user to select print options. When <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns, you can determine whether the user selected the OK, Apply, or Cancel button.  
  
 If the user pressed OK, you can use <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>'s member functions to retrieve the information input by the user.  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> member function is useful for retrieving the current printer defaults without displaying a dialog box. This method requires no user interaction.  
  
 You can use the Windows **CommDlgExtendedError** function to determine whether an error occurred during initialization of the dialog box and to learn more about the error. For more information on this function, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on using <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, see [Common Dialog Classes](../vs140/common-dialog-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="cprintdialogex__cprintdialogex">\</a>  CPrintDialogEx::CPrintDialogEx  
 Constructs a Windows 2000 Print property sheet.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 One or more flags you can use to customize the settings of the dialog box, combined using the bitwise OR operator. For example, the **PD_ALLPAGES** flag sets the default print range to all pages of the document. See the                                 [PRINTDLGEX](http://msdn.microsoft.com/library/windows/desktop/ms646844) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on these flags.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to the dialog box's parent or owner window.  
  
### Remarks  
 This member function only constructs the object. Use the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> member function to display the dialog box.  
  
##  \<a name="cprintdialogex__createprinterdc">\</a>  CPrintDialogEx::CreatePrinterDC  
 Creates a printer device context (DC) from the                 [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Handle to the newly created printer device context.  
  
### Remarks  
 The returned DC is also stored in the **hDC** member of [m_pdex](#cprintdialogex__m_pdex).  
  
 This DC is assumed to be the current printer DC, and any other previously obtained printer DCs must be deleted. This function can be called, and the resulting DC used, without ever displaying the Print dialog box.  
  
##  \<a name="cprintdialogex__domodal">\</a>  CPrintDialogEx::DoModal  
 Call this function to display the Windows 2000 common Print property sheet and allow the user to select various printing options such as the number of copies, page range, and whether copies should be collated.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 The INT_PTR return value is actually an HRESULT. See the Return Values section in                         [PrintDlgEx](http://msdn.microsoft.com/library/windows/desktop/ms646942) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If you want to initialize the various print dialog options by setting members of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> structure, you should do this before calling <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 After calling <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
 If the **PD_RETURNDC** flag is used when calling <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, a printer DC will be returned in the **hDC** member of [m_pdex](#cprintdialogex__m_pdex). This DC must be freed with a call to                         [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) by the caller of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="cprintdialogex__getcopies">\</a>  CPrintDialogEx::GetCopies  
 Call this function after calling <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to retrieve the number of copies requested.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of copies requested.  
  
##  \<a name="cprintdialogex__getdefaults">\</a>  CPrintDialogEx::GetDefaults  
 Call this function to retrieve the device defaults of the default printer without displaying a dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if successful, otherwise **FALSE**.  
  
### Remarks  
 Creates a printer device context (DC) from the                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> does not display the Print property sheet. Instead, it sets the **hDevNames** and **hDevMode** members of [m_pdex](#cprintdialogex__m_pdex) to handles to the                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures that are initialized for the system default printer. Both **hDevNames** and **hDevMode** must be NULL, or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> fails.  
  
 If the **PD_RETURNDC** flag is set, this function will not only return **hDevNames** and **hDevMode** (located in **m_pdex.hDevNames** and **m_pdex.hDevMode**) to the caller, but will also return a printer DC in **m_pdex.hDC**. It is the responsibility of the caller to delete the printer DC and call the Windows                         [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579) function on the handles when you are finished with the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
##  \<a name="cprintdialogex__getdevicename">\</a>  CPrintDialogEx::GetDeviceName  
 Call this function after calling [DoModal](#cprintdialogex__domodal) to retrieve the name of the currently selected printer, or after calling [GetDefaults](#cprintdialogex__getdefaults) to retrieve the name of the default printer.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The name of the currently selected printer.  
  
### Remarks  
 Use a pointer to the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc-class.md#cdc__createdc).  
  
##  \<a name="cprintdialogex__getdevmode">\</a>  CPrintDialogEx::GetDevMode  
 Call this function after calling [DoModal](#cprintdialogex__domodal) or [GetDefaults](#cprintdialogex__getdefaults) to retrieve information about the printing device.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) data structure, which contains information about the device initialization and environment of a print driver. You must unlock the memory taken by this structure with the Windows                         [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595) function, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cprintdialogex__getdrivername">\</a>  CPrintDialogEx::GetDriverName  
 Call this function after calling [DoModal](#cprintdialogex__domodal) or [GetDefaults](#cprintdialogex__getdefaults) to retrieve the name of the system-defined printer device driver.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> specifying the system-defined driver name.  
  
### Remarks  
 Use a pointer to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc-class.md#cdc__createdc).  
  
##  \<a name="cprintdialogex__getportname">\</a>  CPrintDialogEx::GetPortName  
 Call this function after calling [DoModal](#cprintdialogex__domodal) or [GetDefaults](#cprintdialogex__getdefaults) to retrieve the name of the currently selected printer port.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The name of the currently selected printer port.  
  
##  \<a name="cprintdialogex__getprinterdc">\</a>  CPrintDialogEx::GetPrinterDC  
 Returns a handle to the printer device context.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A handle to the printer device context.  
  
### Remarks  
 You must call the Windows                         [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) function to delete the device context when you are done using it.  
  
##  \<a name="cprintdialogex__m_pdex">\</a>  CPrintDialogEx::m_pdex  
 A PRINTDLGEX structure whose members store the characteristics of the dialog object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 After constructing a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object, you can use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to set various aspects of the dialog box before calling the [DoModal](#cprintdialogex__domodal) member function. For more information on the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> structure, see                         [PRINTDLGEX](http://msdn.microsoft.com/library/windows/desktop/ms646844) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If you modify the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> data member directly, you will override any default behavior.  
  
##  \<a name="cprintdialogex__printall">\</a>  CPrintDialogEx::PrintAll  
 Call this function after calling <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to determine whether to print all pages in the document.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if all pages in the document are to be printed; otherwise **FALSE**.  
  
##  \<a name="cprintdialogex__printcollate">\</a>  CPrintDialogEx::PrintCollate  
 Call this function after calling <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> to determine whether the printer should collate all printed copies of the document.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if the user selects the collate check box in the dialog box; otherwise **FALSE**.  
  
##  \<a name="cprintdialogex__printcurrentpage">\</a>  CPrintDialogEx::PrintCurrentPage  
 Call this function after calling <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> to determine whether to print the current page in the document.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if **Print Current Page** is selected in the print dialog; otherwise **FALSE**.  
  
##  \<a name="cprintdialogex__printrange">\</a>  CPrintDialogEx::PrintRange  
 Call this function after calling <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to determine whether to print only a range of pages in the document.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if only a range of pages in the document are to be printed; otherwise **FALSE**.  
  
### Remarks  
 The specified page ranges can be determined from [m_pdex](#cprintdialogex__m_pdex) (see **nPageRanges**, **nMaxPageRanges**, and **lpPageRanges** in the                         [PRINTDLGEX](http://msdn.microsoft.com/library/windows/desktop/ms646844) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]).  
  
##  \<a name="cprintdialogex__printselection">\</a>  CPrintDialogEx::PrintSelection  
 Call this function after calling <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to determine whether to print only the currently selected items.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 **TRUE** if only the selected items are to be printed; otherwise **FALSE**.  
  
## See Also  
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo](../vs140/cprintinfo-structure.md)