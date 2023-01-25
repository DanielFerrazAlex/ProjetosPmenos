function incializar() {
    var cords = { lat: inserirLatitude, lng: inserirLongetude};
    var mapa = new google.maps.Map(document.getElementById('mapa'), {
        zoom: 15,
        center: cords
    });

    var marker = new google.maps.Marker({
        position: cords,
        map: mapa,
        title: 'Meu marcador'
    });
}