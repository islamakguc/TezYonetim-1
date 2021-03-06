﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Forms/Hoca/MasterPageHoca.master" EnableEventValidation="false" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
    <title>AnaSayfa</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <div class="col-sm-3" style="float: left; width: 25%;">
        <!--left col-->
        <ul class="list-group">
            <li id="mainPagePanelHeaderBG1" class="list-group-item text-muted active">
                <div style="display: inline;">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
            </li>
            <li class="list-group-item text-right"><span class="pull-left">
                <i class="fa fa-user fa-1x" title="Adı Soyadı"></i></span>
                <asp:Label ID="Label2" runat="server"></asp:Label></li>

            <li class="list-group-item text-right"><span class="pull-left">
                <i class="fa fa-briefcase fa-1x" title="Bağlı olduğu birim"></i></span>
                <span>
                    <asp:Label ID="Label3" runat="server"></asp:Label></span></li>

            <li class="list-group-item text-right"><span class="pull-left">
                <i class="fa fa-envelope fa-1x" title="E-posta adresi"></i></span>
                <asp:Label ID="Label4" runat="server"></asp:Label></li>
        </ul>
    </div>
    <%-- Boşluk divi --%>
    <div style="float: left; width: 5%;"></div>

    <%-- Tab Başlangıc --%>
    <div style="float: left; width: 70%;">
        <!-- Nav tabs -->
        <ul class="nav nav-tabs" role="tablist">
            <li role="presentation" class="active"><a href="#home" aria-controls="home" role="tab" data-toggle="tab">Duyuru</a></li>
            <li role="presentation"><a href="#profile" aria-controls="profile" role="tab" data-toggle="tab">İşlemler</a></li>
            <li role="presentation"><a href="#messages" aria-controls="messages" role="tab" data-toggle="tab">Mesajlarım</a></li>
        </ul>

        <!-- Tab panes -->
        <div class="tab-content">
            <div role="tabpanel" class="tab-pane active" id="home">
                <div class="panel panel-default">
                    <div class="panel-heading">Duyurular</div>
                    <div class="panel-body" style="text-align: left;">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>

                                <i class="glyphicon glyphicon-bullhorn">&nbsp;</i>
                                <asp:LinkButton ID="LinkButton1" OnCommand="LinkButton1_Click" CommandName="duyuru" CommandArgument='<%#Eval("Id") %>' runat="server"><%#Eval("Duyuru_Tarih") %>  -  <%#Eval("Duyuru_Baslik") %> </asp:LinkButton>
                                <br />
                                <br />

                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
            <div role="tabpanel" class="tab-pane" id="profile">
                <br />
                <br />
                <div style="width: 70%; padding-left: 10%;">
                    <div class="form-group">
                        <asp:TextBox ID="Password" TextMode="Password" placeholder="Eski Şifre" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="Password1" TextMode="Password" placeholder="Yeni Şifre" runat="server" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="Password2" TextMode="Password" placeholder="Yeni şifre Tekrar" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="Button1" class="btn btn-primary" OnClick="Password_Click" runat="server" Text="Şifre Güncelle" />
            </div>
            <div role="tabpanel" class="tab-pane" id="messages">
                <br />
                <div style="height: 450px; overflow-x: hidden; overflow-y: scroll;">


                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <div class="alert alert-success" style="font-size: 12px; text-align: left" role="alert">
                                <%#metin_kisalt_yan(Eval("Gadi").ToString().Trim()) %> <i style="text-align: right; float: right;"><%#Eval("MsjTarih") %></i>
                                <br />
                                <a style="text-decoration: none; color: green" href="MesajGoster.aspx?ID=<%#Eval("Id") %>"><%#metin_kisalt_yan(Eval("MsjText").ToString().Trim()) %></a>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

            </div>
        </div>
        <!-- Tab Bitiş -->
    </div>
    <%-- Modal Başlangıc--%>
    <div class="modal fade" id="exampleModal4" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Kapat"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="exampleModalLabel2">Duyuru ayrıntılar</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <asp:Label ID="Label8" runat="server"></asp:Label><br />
                        <br />
                        <asp:Label ID="Label9" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                </div>
            </div>
        </div>
    </div>
    <%-- Modal Bitiş--%>
</asp:Content>
