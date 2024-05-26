function getDescricaoOrigem() {
    var selectedId = $("#OrigemID").val();
    if (selectedId !== "") {
        $.ajax({
            type: "GET",
            url: "/Ficha/GetOrigemDescricao?id=" + selectedId,
            success: function (response) {
                var descOrigem = response.descOrigem;
                var descPericia1 = response.descPericia1;
                var descPericia2 = response.descPericia2;
                var nomePoder = response.nomePoder;
                var descPoder = response.descPoder;

                $("#descOrigem").text(descOrigem);
                $("#descPericias").html("<p>" + descPericia1 + "</p>" + "<p>" + descPericia2 + "</p>");
                $("#descPoderOrigem").html("<p>" + nomePoder + ":" + "</p>" + "<p>" + descPoder + "</p>");
            },
            error: function () {
                $("#descOrigem").text("Erro ao carregar a descrição.");
                $("#descPericias").text("Erro ao carregar as pericias.");
                $("#descPoderOrigem").text("Erro ao carregar o poder.");
            }
        });
    } else {
        $("#descOrigem").text("");
        $("#descPericias").text("");
        $("#descPoderOrigem").text("");
    }
}

function getDescricaoClasse() {
    var selectedId = $("#ClasseID").val();
    if (selectedId !== "") {
        $.ajax({
            type: "GET",
            url: "/Ficha/GetClasseDescricao?id=" + selectedId,
            success: function (response) {
                var descClasse = response.descClasse;
                var descPtVidaInicial = response.descPtVidaInicial;
                var descPtVidaNex = response.descPtVidaNex;
                var descPtEsforcoInicial = response.descPtEsforcoInicial;
                var descPtEsforcoNex = response.descPtEsforcoNex;
                var descSanInicial = response.descSanInicial;
                var descSanidadeNex = response.descSanidadeNex;
                var descPericiasTreinadas = response.descPericiasTreinadas;
                var descProficiencias = response.descProficiencias;
                var descHabilidadeClasseTitle = response.descHabilidadeClasseTitle;
                var descHabilidadeClasse = response.descHabilidadeClasse;

                $("#descClasse").text(descClasse);

                $("#descCaracteristicaClasse").html(
                    "<p>" + "PV Inicial: " + descPtVidaInicial + " + Vigor" + "</p>" +
                    "<p>" + "PV (Novo NEX): " + descPtVidaNex + " + Vigor" + "</p>" +
                    "<p>" + "PE Inicial: " + descPtEsforcoInicial + " + Presença" + "</p>" +
                    "<p>" + "PE (Novo NEX): " + descPtEsforcoNex + " + Presença" + "</p>" +
                    "<p>" + "Sanidade Inicial: " + descSanInicial + "</p>" +
                    "<p>" + "Sanidade (Novo NEX): " + descSanidadeNex + "</p>"
                );

                $("#descPericiasClasse").html("<p>" + descPericiasTreinadas + "</p>");

                $("#descProficienciasClasse").html("<p>" + descProficiencias + "</p>");

                $("#descModalHablidade").html("<p>" + descHabilidadeClasseTitle + "</p>" + "<br>" + "<p>" + descHabilidadeClasse + "</p>");
            },
            error: function () {
                $("#descClasse").text("Erro ao carregar a descrição.");
                $("#descCaracteristicaClasse").text("Erro ao carregar as pericias.");
                $("#descPericiasClasse").text("Erro ao carregar o poder.");
                $("#descProficienciasClasse").text("Erro ao carregar o poder.");
                $("descModalHablidade").text("Erro ao carregar o poder.")
            }
        });
    }
    else {
        $("#descClasse").text("");
        $("#descCaracteristicaClasse").text("");
        $("#descPericiasClasse").text("");
        $("#descProficienciasClasse").text("");
        $("descModalHablidade").text("");
    }
}

function iniciarModal() {
    var modal = document.getElementById("modalPoder");
    var btn = document.getElementById("mdlBtnPoder");
    var span = document.getElementsByClassName("close")[0];

    btn.onclick = function () {
        modal.style.display = "block";
    }

    span.onclick = function () {
        modal.style.display = "none";
    }

    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
}

iniciarModal();
