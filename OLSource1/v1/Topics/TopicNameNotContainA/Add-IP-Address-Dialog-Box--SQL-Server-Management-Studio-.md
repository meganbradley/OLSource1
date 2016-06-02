---
title: Add IP Address Dialog Box (SQL Server Management Studio)
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - dbe-high-availability
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 98c9ad3b-ff3c-4c1d-b344-59a72fca137c
---
# Add IP Address Dialog Box (SQL Server Management Studio)
  This F1 help topic describes the options of the **Add IP Address** dialog box. This dialog box accessed from the **New Availability Group Listener** dialog box and the **Listener** tab of the **Specify Replicas** page of the [!INCLUDE[ssAoNewAgWiz](../../Token\Other/ssAoNewAgWiz_md.md)] or the [!INCLUDE[ssAoAddRepWiz](../../Token\Other/ssAoAddRepWiz_md.md)] of [!INCLUDE[ssCurrent](../../Token\Other/ssCurrent_md.md)].  
  
## Prerequisites  
 Before you begin to add subnets to an availability group listener, ensure that know the IP address for each subnet and, for an IPv4 address, the subnet mask.  
  
##  <a name="PageOptions"></a> Add IP Address Options  
 **Subnet**  
 Use the drop list to select an address for the subnet that you are adding to the availability group listener. By default a subnet possesses both an IPv4 address and an IPv6 address. The first time you use the **Add IP Address** dialog,  the **Subnet** drop list displays both subnet addresses for each subnet that hosts a replica for the availability group. To add a given subnet to the listener, select one of its subnet addresses.  
  
 After you complete the **Add IP Address** dialog box and click **OK** to add a selected subnet address to the listener, the **Subnet** drop list filters out that subnet address. All unselected subnet addresses remain on the drop list. Be sure that you add one and only one subnet address per subnet to the listener, or listener creation will fail.  
  
 **Addresses**  
 Use this field to enter a static IP address for the selected subnet address. Contact your network administrator for this IP address. Ensure that you enter a valid address for the selected subnet address, or listener creation will fail.  
  
 **IPv4 Address**  
 If you selected the IPv4 subnet address of a subnet, enter a valid IPv4 static address here.  
  
 **Subnet Mask**  
 For an IPv4 address, this read\-only field displays the subnet mask of the selected subnet.  
  
 **IPv6 Address**  
 If you selected the IPv6 subnet address of a subnet, enter a valid IPv6 static address here.  
  
 **OK**  
 Click to create add the subnet whose address you selected, along with the static IP address that you specified. A row containing these values will be added to the subnet grid of the **New Availability Group Listener** or **Specify Replicas** dialog box.  
  
> [!IMPORTANT]  
>  The **Add IP Address** dialog does not verify the IP address. Also the dialog does not prevent you from adding the second subnet address for a subnet that you have already added to the availability group listener.  
  
 **Cancel**  
 Click to cancel your selections, and return to the **New Availability Group Listener** dialog box or **Listener** tab without adding a static IP address for any subnet.  
  
##  <a name="RelatedTasks"></a> Related Tasks  
  
-   [Create or Configure an Availability Group Listener &#40;SQL Server&#41;](../Topic/Create%20or%20Configure%20an%20Availability%20Group%20Listener%20\(SQL%20Server\).md)  
  
-   [Use the New Availability Group Dialog Box &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20New%20Availability%20Group%20Dialog%20Box%20\(SQL%20Server%20Management%20Studio\).md)  
  
-   [Use the Add Replica to Availability Group Wizard &#40;SQL Server Management Studio&#41;](../Topic/Use%20the%20Add%20Replica%20to%20Availability%20Group%20Wizard%20\(SQL%20Server%20Management%20Studio\).md)  
  
## See Also  
 [Overview of Always On Availability Groups &#40;SQL Server&#41;](../Topic/Overview%20of%20Always%20On%20Availability%20Groups%20\(SQL%20Server\).md)   
 [Availability Group Listeners, Client Connectivity, and Application Failover &#40;SQL Server&#41;](../Topic/Availability%20Group%20Listeners,%20Client%20Connectivity,%20and%20Application%20Failover%20\(SQL%20Server\).md)   
 [Always On Client Connectivity &#40;SQL Server&#41;](../Topic/Always%20On%20Client%20Connectivity%20\(SQL%20Server\).md)  
  
  