function MostarActores(idActor){
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'Home/VerActoresAjax',
        data: {IdActor: idActor},
        success:
            function(response){
                $("#NombreActores").html(response.nombre);
            }
    });
}

function MostrarTemporadas(idTemporada){
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'Home/VerTemporadasAjax',
        data: {IdTemporada: idTemporada},
        success:
            function(response){
                $("#NumeroTemporada").html(response.numeroTemporada);
                $("#NombreTemporada").html(response.tituloTemporada);
            }
    });
}

function MostrarMasInfo(idSerie){
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: 'Home/VerMasInfoAjax',
        data: {IdSerie: idSerie},
        success:
            function(response){
                $("#AñoInicio").html(response.añoInicio);
                $("#Sinopsis").html(response.sinopsis);
                $("#ImgSerie").attr("src", "img/" +  response.imagenSerie)
            }
    });
}
