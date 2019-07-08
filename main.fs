#require MBSERVER

  5 CONSTANT BAUD115200

NVM
  \ --- MODBUS server startup

  : init ( -- )
    BAUD115200 UARTISR
    1 mbnode !
    MBSERVER
  ;

  ' init    'BOOT !
RAM
