---
title: "CPrintDialog Class"
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
  - "CPrintDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Print Setup dialog box"
  - "Print dialog box"
  - "CPrintDialog class"
ms.assetid: 5bdb2424-adf8-433d-a97c-df11a83bc4e4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog Class
Encapsulates the services provided by the Windows common dialog box for printing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPrintDialog::CPrintDialog](#cprintdialog__cprintdialog)|Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPrintDialog::CreatePrinterDC](#cprintdialog__createprinterdc)|Creates a printer device context without displaying the Print dialog box.|  
|[CPrintDialog::DoModal](#cprintdialog__domodal)|Displays the dialog box and allows the user to make a selection.|  
|[CPrintDialog::GetCopies](#cprintdialog__getcopies)|Retrieves the number of copies requested.|  
|[CPrintDialog::GetDefaults](#cprintdialog__getdefaults)|Retrieves device defaults without displaying a dialog box.|  
|[CPrintDialog::GetDeviceName](#cprintdialog__getdevicename)|Retrieves the name of the currently selected printer device.|  
|[CPrintDialog::GetDevMode](#cprintdialog__getdevmode)|Retrieves the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> structure.|  
|[CPrintDialog::GetDriverName](#cprintdialog__getdrivername)|Retrieves the name of the currently selected printer driver.|  
|[CPrintDialog::GetFromPage](#cprintdialog__getfrompage)|Retrieves the starting page of the print range.|  
|[CPrintDialog::GetPortName](#cprintdialog__getportname)|Retrieves the name of the currently selected printer port.|  
|[CPrintDialog::GetPrinterDC](#cprintdialog__getprinterdc)|Retrieves a handle to the printer device context.|  
|[CPrintDialog::GetToPage](#cprintdialog__gettopage)|Retrieves the ending page of the print range.|  
|[CPrintDialog::PrintAll](#cprintdialog__printall)|Determines whether to print all pages of the document.|  
|[CPrintDialog::PrintCollate](#cprintdialog__printcollate)|Determines whether collated copies are requested.|  
|[CPrintDialog::PrintRange](#cprintdialog__printrange)|Determines whether to print only a specified range of pages.|  
|[CPrintDialog::PrintSelection](#cprintdialog__printselection)|Determines whether to print only the currently selected items.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPrintDialog::m_pd](#cprintdialog__m_pd)|A structure used to customize a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Common print dialog boxes provide an easy way to implement Print and Print Setup dialog boxes in a manner consistent with Windows standards.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class encapsulates the services provided by the Windows 2000 Print property sheet. For more information see the [CPrintDialogEx](../vs140/cprintdialogex-class.md) overview.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>'s functionality is superceded by that of [CPageSetupDialog](../vs140/cpagesetupdialog-class.md), which is designed to provide you with a common dialog box for both print setup and page setup.  
  
 You can rely on the framework to handle many aspects of the printing process for your application. In this case, the framework automatically displays the Windows common dialog box for printing. You can also have the framework handle printing for your application but override the common Print dialog box with your own print dialog box. For more information about using the framework to handle printing tasks, see the article [Printing](../vs140/printing.md).  
  
 If you want your application to handle printing without the framework's involvement, you can use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> class "as is" with the constructor provided, or you can derive your own dialog class from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and write a constructor to suit your needs. In either case, these dialog boxes will behave like standard MFC dialog boxes because they are derived from class <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 To use a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object, first create the object using the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> constructor. Once the dialog box has been constructed, you can set or modify any values in the [m_pd](#cprintdialog__m_pd) structure to initialize the values of the dialog box's controls. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> structure is of type                 [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843). For more information on this structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If you do not supply your own handles in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for the **hDevMode** and **hDevNames** members, be sure to call the Windows function **GlobalFree** for these handles when you are done with the dialog box. When using the framework's Print Setup implementation provided by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, you do not have to free these handles. The handles are maintained by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and are freed in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>'s destructor. It is only necessary to free these handles when using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> stand-alone.  
  
 After initializing the dialog box controls, call the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> member function to display the dialog box and allow the user to select print options. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> returns whether the user selected the OK ( **IDOK**) or Cancel ( **IDCANCEL**) button.  
  
 If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> returns **IDOK**, you can use one of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>'s member functions to retrieve the information input by the user.  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> member function is useful for retrieving the current printer defaults without displaying a dialog box. This member function requires no user interaction.  
  
 You can use the Windows **CommDlgExtendedError** function to determine whether an error occurred during initialization of the dialog box and to learn more about the error. For more information on this function, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> relies on the COMMDLG.DLL file that ships with Windows versions 3.1 and later.  
  
 To customize the dialog box, derive a class from <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, provide a custom dialog template, and add a message map to process the notification messages from the extended controls. Any unprocessed messages should be passed on to the base class. Customizing the hook function is not required.  
  
 To process the same message differently depending on whether the dialog box is Print or Print Setup, you must derive a class for each dialog box. You must also override the Windows **AttachOnSetup** function, which handles the creation of a new dialog box when the Print Setup button is selected within a Print dialog box.  
  
 For more information on using <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, see [Common Dialog Classes](../vs140/common-dialog-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="cprintdialog__cprintdialog">\</a>  CPrintDialog::CPrintDialog  
 Constructs either a Windows Print or Print Setup dialog object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies whether the standard Windows Print dialog box or Print Setup dialog box is displayed. Set this parameter to **TRUE** to display the standard Windows Print Setup dialog box. Set it to **FALSE** to display the Windows Print dialog box. If <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is **FALSE**, a Print Setup option button is still displayed in the Print dialog box.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 One or more flags you can use to customize the settings of the dialog box, combined using the bitwise OR operator. For example, the **PD_ALLPAGES** flag sets the default print range to all pages of the document. See the                                 [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on these flags.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to the dialog box's parent or owner window.  
  
### Remarks  
 This member function only constructs the object. Use the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> member function to display the dialog box.  
  
 Note that when you call the constructor with <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> set to **FALSE**, the **PD_RETURNDC** flag is automatically used. After calling <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, a printer DC will be returned in <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. This DC must be freed with a call to                         [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) by the caller of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#174](../vs140/codesnippet/CPP/cprintdialog-class_1.cpp)]  
  
##  \<a name="cprintdialog__createprinterdc">\</a>  CPrintDialog::CreatePrinterDC  
 Creates a printer device context (DC) from the                 [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Handle to the newly created printer device context.  
  
### Remarks  
 This DC is assumed to be the current printer DC, and any other previously obtained printer DCs must be deleted by the user. This function can be called, and the resulting DC used, without ever displaying the Print dialog box.  
  
### Example  
 [!code[NVC_MFCDocView#106](../vs140/codesnippet/CPP/cprintdialog-class_2.cpp)]  
  
##  \<a name="cprintdialog__domodal">\</a>  CPrintDialog::DoModal  
 Displays the Windows common print dialog box and allows the user to select various printing options such as the number of copies, page range, and whether copies should be collated.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows                         [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
### Remarks  
 If you want to initialize the various print dialog options by setting members of the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> structure, you should do this before calling <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 After calling <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
 Note that when you call the constructor with <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> set to **FALSE**, the **PD_RETURNDC** flag is automatically used. After calling <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, a printer DC will be returned in <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. This DC must be freed with a call to                         [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) by the caller of <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CPrintDialog::CreatePrinterDC](#cprintdialog__createprinterdc).  
  
##  \<a name="cprintdialog__getcopies">\</a>  CPrintDialog::GetCopies  
 Retrieves the number of copies requested.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of copies requested.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to retrieve the number of copies requested.  
  
### Example  
  See the example for [CPrintDialog::PrintCollate](#cprintdialog__printcollate).  
  
##  \<a name="cprintdialog__getdefaults">\</a>  CPrintDialog::GetDefaults  
 Retrieves the device defaults of the default printer without displaying a dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 The retrieved values are placed in the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> structure.  
  
 In some cases, a call to this function will call the [constructor](#cprintdialog__cprintdialog) for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> set to **FALSE**. In these cases, a printer DC and **hDevNames** and **hDevMode** (two handles located in the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> data member) are automatically allocated.  
  
 If the constructor for <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> was called with <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> set to **FALSE**, this function will not only return **hDevNames** and **hDevMode** (located in **m_pd.hDevNames** and **m_pd.hDevMode**) to the caller, but will also return a printer DC in **m_pd.hDC**. It is the responsibility of the caller to delete the printer DC and call the Windows                         [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579) function on the handles when you are finished with the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
### Example  
 This code fragment gets the default printer's device context and reports to the user the resolution of the printer in dots per inch. (This attribute of the printer's capabilities is often referred to as DPI.)  
  
 [!code[NVC_MFCDocView#107](../vs140/codesnippet/CPP/cprintdialog-class_3.cpp)]  
  
##  \<a name="cprintdialog__getdevicename">\</a>  CPrintDialog::GetDeviceName  
 Retrieves the name of the currently selected printer device.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The name of the currently selected printer.  
  
### Remarks  
 Call this function after calling [DoModal](#cprintdialog__domodal) to retrieve the name of the currently selected printer, or after calling [GetDefaults](#cprintdialog__getdefaults) to retrieve the current device defaults of the default printer. Use a pointer to the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc-class.md#cdc__createdc).  
  
### Example  
 This code fragment shows the user's default printer name and the port it is connected to, along with the spooler name the printer uses. The code might show a message box that says, "Your default printer is HP LaserJet IIIP on \\\server\share using winspool.", for example.  
  
 [!code[NVC_MFCDocView#108](../vs140/codesnippet/CPP/cprintdialog-class_4.cpp)]  
  
##  \<a name="cprintdialog__getdevmode">\</a>  CPrintDialog::GetDevMode  
 Retrieves the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> structure.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) data structure, which contains information about the device initialization and environment of a print driver. You must unlock the memory taken by this structure with the Windows                         [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595) function, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 Call this function after calling [DoModal](#cprintdialog__domodal) or [GetDefaults](#cprintdialog__getdefaults) to retrieve information about the printing device.  
  
### Example  
  See the example for [CPrintDialog::PrintCollate](#cprintdialog__printcollate).  
  
##  \<a name="cprintdialog__getdrivername">\</a>  CPrintDialog::GetDriverName  
 Retrieves the name of the currently selected printer driver.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> specifying the system-defined driver name.  
  
### Remarks  
 Call this function after calling [DoModal](#cprintdialog__domodal) or [GetDefaults](#cprintdialog__getdefaults) to retrieve the name of the system-defined printer device driver. Use a pointer to the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc-class.md#cdc__createdc).  
  
### Example  
  See the example for [CPrintDialog::GetDeviceName](#cprintdialog__getdevicename).  
  
##  \<a name="cprintdialog__getfrompage">\</a>  CPrintDialog::GetFromPage  
 Retrieves the starting page of the print range.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The starting page number in the range of pages to be printed.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> to retrieve the starting page number in the range of pages to be printed.  
  
### Example  
  See the example for [CPrintDialog::m_pd](#cprintdialog__m_pd).  
  
##  \<a name="cprintdialog__getportname">\</a>  CPrintDialog::GetPortName  
 Retrieves the name of the currently selected printer port.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The name of the currently selected printer port.  
  
### Remarks  
 Call this function after calling [DoModal](#cprintdialog__domodal) or [GetDefaults](#cprintdialog__getdefaults) to retrieve the name of the currently selected printer port.  
  
### Example  
  See the example for [CPrintDialog::GetDeviceName](#cprintdialog__getdevicename).  
  
##  \<a name="cprintdialog__getprinterdc">\</a>  CPrintDialog::GetPrinterDC  
 Retrieves a handle to the printer device context.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A handle to the printer device context if successful; otherwise **NULL**.  
  
### Remarks  
 If the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> constructor was **FALSE** (indicating that the Print dialog box is displayed), then <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> returns a handle to the printer device context. You must call the Windows                         [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) function to delete the device context when you are done using it.  
  
### Example  
 [!code[NVC_MFCDocView#109](../vs140/codesnippet/CPP/cprintdialog-class_5.cpp)]  
  
##  \<a name="cprintdialog__gettopage">\</a>  CPrintDialog::GetToPage  
 Retrieves the ending page of the print range.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The ending page number in the range of pages to be printed.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to retrieve the ending page number in the range of pages to be printed.  
  
### Example  
  See the example for [CPrintDialog::m_pd](#cprintdialog__m_pd).  
  
##  \<a name="cprintdialog__m_pd">\</a>  CPrintDialog::m_pd  
 A structure whose members store the characteristics of the dialog object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 After constructing a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object, you can use <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to set various aspects of the dialog box before calling the [DoModal](#cprintdialog__domodal) member function. For more information on the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> structure, see                         [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 If you modify the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> data member directly, you will override any default behavior.  
  
### Example  
 [!code[NVC_MFCDocView#111](../vs140/codesnippet/CPP/cprintdialog-class_6.cpp)]  
  
##  \<a name="cprintdialog__printall">\</a>  CPrintDialog::PrintAll  
 Determines whether to print all pages of the document.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if all pages in the document are to be printed; otherwise 0.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> to determine whether to print all pages in the document.  
  
### Example  
  See the example for [CPrintDialog::m_pd](#cprintdialog__m_pd).  
  
##  \<a name="cprintdialog__printcollate">\</a>  CPrintDialog::PrintCollate  
 Determines whether collated copies are requested.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the user selects the collate check box in the dialog box; otherwise 0.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> to determine whether the printer should collate all printed copies of the document.  
  
### Example  
 [!code[NVC_MFCDocView#110](../vs140/codesnippet/CPP/cprintdialog-class_7.cpp)]  
  
##  \<a name="cprintdialog__printrange">\</a>  CPrintDialog::PrintRange  
 Determines whether to print only a specified range of pages.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if only a range of pages in the document are to be printed; otherwise 0.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> to determine whether to print only a range of pages in the document.  
  
### Example  
  See the example for [CPrintDialog::m_pd](#cprintdialog__m_pd).  
  
##  \<a name="cprintdialog__printselection">\</a>  CPrintDialog::PrintSelection  
 Determines whether to print only the currently selected items.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if only the selected items are to be printed; otherwise 0.  
  
### Remarks  
 Call this function after calling <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> to determine whether to print only the currently selected items.  
  
### Example  
  See the example for [CPrintDialog::m_pd](#cprintdialog__m_pd).  
  
## See Also  
 [MFC Sample DIBLOOK](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo](../vs140/cprintinfo-structure.md)