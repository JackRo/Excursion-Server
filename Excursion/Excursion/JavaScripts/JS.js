﻿
function show_menu(num) {
    for (i = 0; i < 100; i++) {
        if ($('li0' + i)) {
            $('li0' + i).style.display = 'none';
            $('f0' + i).className = '';
        }
    }
    $('li0' + num).style.display = 'block';//触发以后信息块
    $('f0' + num).className = 'left02down01_xia_li';//触发以后TAG样式
}

function show_menuB(numB) {
    for (j = 0; j < 100; j++) {
        if (j != numB) {
            if ($('Bli0' + j)) {
                $('Bli0' + j).style.display = 'none';
                $('Bf0' + j).style.background = 'url(../Images/01.gif)';
            }
        }
    }
    if ($('Bli0' + numB)) {
        if ($('Bli0' + numB).style.display == 'block') {
            $('Bli0' + numB).style.display = 'none';
            $('Bf0' + numB).style.background = 'url(../Images/01.gif)';
        } else {
            $('Bli0' + numB).style.display = 'block';
            $('Bf0' + numB).style.background = 'url(../Images/02.gif)';
        }
    }
}


var temp = 0;
function show_menuC() {
    if (temp == 0) {
        document.getElementById('LeftBox').style.display = 'none';
        document.getElementById('RightBox').style.marginLeft = '0';
        document.getElementById('Mobile').style.background = 'url(../Images/center.gif)';

        temp = 1;
    } else {
        document.getElementById('RightBox').style.marginLeft = '222px';
        document.getElementById('LeftBox').style.display = 'block';
        document.getElementById('Mobile').style.background = 'url(../Images/center0.gif)';

        temp = 0;
    }
}
