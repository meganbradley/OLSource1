---
title: "How to: Configure Inclusion List Security"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "permissions [Office development in Visual Studio"
  - "inclusion lists [Office development in Visual Studio]"
ms.assetid: 0609d8f0-4630-4e17-aeb3-14f3134165cf
caps.latest.revision: 26
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Configure Inclusion List Security
  If you have Administrator permissions, you can configure the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] trust prompt to control whether end users are given the option of installing Office solutions by saving a trust decision to the inclusion list. For information about inclusion lists, see [Trusting Office Solutions by Using Inclusion Lists](../VS_officedev/trusting-office-solutions-by-using-inclusion-lists.md).  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
 For solutions that are in each of five zones, you can set the following options:  
  
-   Enable the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] Trust Prompt Key and the inclusion list. You can allow end users to grant trust to Office solutions that are signed with any certificate.  
  
-   Restrict the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] Trust Prompt Key and the inclusion list. You can allow end users to install Office solutions that are signed with a certificate that identifies the publisher, but that is not already trusted.  
  
-   Disable the [!INCLUDE[ndptecclick](../VS_officedev/includes/ndptecclick_md.md)] Trust Prompt Key and the inclusion list. You can prevent end users from installing any Office solution that is not signed with an explicitly trusted certificate.  
  
## Enabling the Inclusion List  
 Enable the inclusion list for a zone when you want end users to be presented with the option of installing and running any Office solution that comes from that zone.  
  
#### To enable the inclusion list by using the registry editor  
  
1.  Open the registry editor:  
  
    1.  Click **Start**, and then click **Run**.  
  
    2.  In the **Open** box, type **regedt32.exe**, and then click **OK**.  
  
2.  Find the following registry key:  
  
     \HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\\.NETFramework\Security\TrustManager\PromptingLevel  
  
     If the key does not exist, create it.  
  
3.  Add the following subkeys as **String Value**, if they do not already exist, with the associated values.  
  
    |String Value subkey|Value|  
    |-------------------------|-----------|  
    |**Internet**|**AuthenticodeRequired**|  
    |**UntrustedSites**|**Disabled**|  
    |**MyComputer**|**Enabled**|  
    |**LocalIntranet**|**Enabled**|  
    |**TrustedSites**|**Enabled**|  
  
     By default, **Internet** has the value **AuthenticodeRequired** and **UntrustedSites** has the value **Disabled**.  
  
#### To enable the inclusion list programmatically  
  
1.  Create a Visual Basic or Visual C# console application.  
  
2.  Open the Program.vb or Program.cs file for editing and add the following code.  
  
    ```vb#  
    Dim key As Microsoft.Win32.RegistryKey  
    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\MICROSOFT\.NETFramework\Security\TrustManager\PromptingLevel")  
    key.SetValue("MyComputer", "Enabled")  
    key.SetValue("LocalIntranet", "Enabled")  
    key.SetValue("Internet", "AuthenticodeRequired")  
    key.SetValue("TrustedSites", "Enabled")  
    key.SetValue("UntrustedSites", "Disabled")  
    key.Close()  
    ```  
  
    ```c#  
    Microsoft.Win32.RegistryKey key;  
    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\MICROSOFT\\.NETFramework\\Security\\TrustManager\\PromptingLevel");  
    key.SetValue("MyComputer", "Enabled");  
    key.SetValue("LocalIntranet", "Enabled");  
    key.SetValue("Internet", "AuthenticodeRequired");  
    key.SetValue("TrustedSites", "Enabled");  
    key.SetValue("UntrustedSites", "Disabled");  
    key.Close();  
    ```  
  
3.  Build and run the application.  
  
## Restricting the Inclusion List  
 Restrict the inclusion list so that solutions must be signed with Authenticode certificates that have known identity before users are prompted for a trust decision.  
  
#### To restrict the inclusion list  
  
1.  Open the registry editor:  
  
    1.  Click **Start**, and then click **Run**.  
  
    2.  In the **Open** box, type **regedt32.exe**, and then click **OK**.  
  
2.  Find the following registry key:  
  
     \HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\\.NETFramework\Security\TrustManager\PromptingLevel  
  
     If the key does not exist, create it.  
  
3.  Add the following subkeys as **String Value**, if they do not already exist, with the associated values.  
  
    |String Value subkey|Value|  
    |-------------------------|-----------|  
    |**UntrustedSites**|**Disabled**|  
    |**Internet**|**AuthenticodeRequired**|  
    |**MyComputer**|**AuthenticodeRequired**|  
    |**LocalIntranet**|**AuthenticodeRequired**|  
    |**TrustedSites**|**AuthenticodeRequired**|  
  
     By default, **Internet** has the value **AuthenticodeRequired** and **UntrustedSites** has the value **Disabled**.  
  
#### To restrict the inclusion list programmatically  
  
1.  Create a Visual Basic or Visual C# console application.  
  
2.  Open the Program.vb or Program.cs file for editing and add the following code.  
  
    ```vb#  
    Dim key As Microsoft.Win32.RegistryKey  
    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\MICROSOFT\.NETFramework\Security\TrustManager\PromptingLevel")  
    key.SetValue("MyComputer", "AuthenticodeRequired")  
    key.SetValue("LocalIntranet", "AuthenticodeRequired")  
    key.SetValue("Internet", "AuthenticodeRequired")  
    key.SetValue("TrustedSites", "AuthenticodeRequired")  
    key.SetValue("UntrustedSites", "Disabled")  
    key.Close()  
    ```  
  
    ```c#  
    Microsoft.Win32.RegistryKey key;  
    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\MICROSOFT\\.NETFramework\\Security\\TrustManager\\PromptingLevel");  
    key.SetValue("MyComputer", "AuthenticodeRequired");  
    key.SetValue("LocalIntranet", "AuthenticodeRequired");  
    key.SetValue("Internet", "AuthenticodeRequired");  
    key.SetValue("TrustedSites", "AuthenticodeRequired");  
    key.SetValue("UntrustedSites", "Disabled");  
    key.Close();  
    ```  
  
3.  Build and run the application.  
  
## Disabling the Inclusion List  
 You can disable the inclusion list so that end users can only install solutions that are signed with a trusted and known certificate.  
  
#### To disable the inclusion list  
  
1.  Open the registry editor:  
  
    1.  Click **Start**, and then click **Run**.  
  
    2.  In the **Open** box, type **regedt32.exe**, and then click **OK**.  
  
2.  Create the following registry key if this does not already exist:  
  
     **\HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\\.NETFramework\Security\TrustManager\PromptingLevel**  
  
3.  Add the following subkeys as **String Value**, if they do not already exist, with the associated values.  
  
    |String Value subkey|Value|  
    |-------------------------|-----------|  
    |**UntrustedSites**|**Disabled**|  
    |**Internet**|**Disabled**|  
    |**MyComputer**|**Disabled**|  
    |**LocalIntranet**|**Disabled**|  
    |**TrustedSites**|**Disabled**|  
  
#### To disable the inclusion list programmatically  
  
1.  Create a Visual Basic or Visual C# console application.  
  
2.  Open the Program.vb or Program.cs file for editing and add the following code.  
  
    ```vb#  
    Dim key As Microsoft.Win32.RegistryKey  
    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\MICROSOFT\.NETFramework\Security\TrustManager\PromptingLevel")  
    key.SetValue("MyComputer", "Disabled")  
    key.SetValue("LocalIntranet", "Disabled")  
    key.SetValue("Internet", "Disabled")  
    key.SetValue("TrustedSites", "Disabled")  
    key.SetValue("UntrustedSites", "Disabled")  
    key.Close()  
    ```  
  
    ```c#  
    Microsoft.Win32.RegistryKey key;  
    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\\MICROSOFT\\.NETFramework\\Security\\TrustManager\\PromptingLevel");  
    key.SetValue("MyComputer", "Disabled");  
    key.SetValue("LocalIntranet", "Disabled");  
    key.SetValue("Internet", "Disabled");  
    key.SetValue("TrustedSites", "Disabled");  
    key.SetValue("UntrustedSites", "Disabled");  
    key.Close();  
  
    ```  
  
3.  Build and run the application.  
  
## See Also  
 [Trusting Office Solutions by Using Inclusion Lists](../VS_officedev/trusting-office-solutions-by-using-inclusion-lists.md)   
 [Securing Office Solutions](../VS_officedev/securing-office-solutions.md)  
  
  