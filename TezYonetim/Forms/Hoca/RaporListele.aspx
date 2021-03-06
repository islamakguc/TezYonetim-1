﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Hoca/MasterPageHoca.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RaporListele.aspx.cs" Inherits="Forms_Hoca_RaporListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Rapor Görüntüle</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <script type="text/javascript">
        $(function () {
            $('.modal-button').click(function () {
                //modalı aç;
                $("#exampleModal2").find("input[type='hidden']").val($(this).attr("data-id"));
                $('.modal').modal();
                //false return etmezsen sayfa navigate olur
                return false;
            });
        });
    </script>
     <div id="gosterme" runat="server">
        <asp:Label ID="lbgosterme" runat="server" Text="Label"></asp:Label></div>
    <div id="goster" runat="server">
    <table class="display" id="students">
        <thead>
            <tr>
                <th style="text-align: center;">Konu </th>
                <th style="text-align: center;">Açıklama </th>
                <th style="text-align: center;">Öğrenci Sayısı</th>
                <th style="text-align: center;">Düzenle</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#metin_kisalt_yan(Eval("Konu").ToString().Trim()) %></td>
                        <td><%#metin_kisalt_yan(Eval("Aciklama").ToString().Trim()) %> </td>
                        <td><%#Eval("Tez_Alan") %></td>
                        <td>
                            <div class="btn-group">
                                <button class="btn btn-default btn-sm dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                    İşlemler <span class="caret"></span>
                                </button>
                                <ul class="dropdown-menu">
                                    <li>
                                        <asp:LinkButton ID="genel" runat="server" OnCommand="Goster_Click" data-id='<%#Eval("Id") %>' CommandName="Goruntule" CommandArgument='<%#Eval("Id") %>'>Rapor Görüntüle</asp:LinkButton></li>
                                    <li>
                                        <asp:LinkButton ID="vize" runat="server" OnCommand="Goster_Click" data-id='<%#Eval("Id") %>' CommandName="Goruntulevize" CommandArgument='<%#Eval("Id") %>'>Vize Rapor Görüntüle</asp:LinkButton></li>
                                    <li>
                                        <asp:LinkButton ID="final" runat="server" OnCommand="Goster_Click" data-id='<%#Eval("Id") %>' CommandName="Goruntulefinal" CommandArgument='<%#Eval("Id") %>'>Final Rapor Görüntüle</asp:LinkButton></li>
                                </ul>
                            </div>

                        </td>
                        <td></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
        </div>
    <br />
    <%-- Modal başlangıç --%>
    <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Kapat"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="exampleModalLabel2">Rapor Yükleme</h4>
                </div>
                <div class="modal-body">
                    <asp:Label ID="Label1" runat="server" Font-Size="18px" Text="Tez Öğrencileri"></asp:Label><br />
                    <asp:Label ID="TezOgrLbl" runat="server"></asp:Label><br />
                    <br />
                    <br />
                    <div class="form-group">
                        <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                            <asp:Repeater ID="Repeater2" runat="server" OnItemDataBound="Repeater2_ItemDataBound">
                                <HeaderTemplate>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="panel panel-primary">
                                        <div class="panel-heading" role="tab" id="headingTwo">
                                            <h6 class="panel-title" style="text-align: left;">
                                                <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#<%#Eval("Id") %>" aria-expanded="false" aria-controls="<%#Eval("Id") %>">
                                                    <asp:Label ID="lblrapor" runat="server"></asp:Label>
                                                    <%=++sayac%>                        
                                                </a>
                                            </h6>
                                        </div>
                                        <div id="<%#Eval("Id") %>" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                                            <div class="panel-body" style="text-align: left;">
                                                <b>Rapor Başlangıç</b> = <%#Eval("RaporBas") %><br />
                                                <b>Rapor Biriş</b> = <%#Eval("RaporBit") %><br />
                                                <br />
                                                <asp:Button CssClass="btn btn-primary" type="button" ID="goruntule" runat="server" OnCommand="RaporGoruntule" CommandName="Goruntule" CommandArgument='<%#Eval("Id") %>' Text="Rapor Görüntüle" />
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                </FooterTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Kapat</button>
                </div>
            </div>
        </div>
    </div>
    <%-- Modal Bitiş --%>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#students').DataTable({
                "aLengthMenu": [[20, 40, 60, 100, -1], [20, 40, 60, 100, "Hepsi"]],
                "iDisplayLength": 20,
                "language": {
                    "sDecimal": ",",
                    "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
                    "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
                    "sInfoEmpty": "Kayıt yok",
                    "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
                    "sInfoPostFix": "",
                    "sInfoThousands": ".",
                    "sLengthMenu": "Sayfada _MENU_ kayıt göster",
                    "sLoadingRecords": "Yükleniyor...",
                    "sProcessing": "İşleniyor...",
                    "sSearch": "Ara:",
                    "sZeroRecords": "Eşleşen kayıt bulunamadı",
                    "oPaginate": {
                        "sFirst": "İlk",
                        "sLast": "Son",
                        "sNext": "Sonraki",
                        "sPrevious": "Önceki"
                    },
                    "oAria": {
                        "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                        "sSortDescending": ": azalan sütun soralamasını aktifleştir"
                    },
                }
            });
        });
    </script>
</asp:Content>

