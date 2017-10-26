package main

import (
    "fmt"
    "log"
    "net"
    "time"
)

func main() {

    // listen on a port
    ln, err := net.Listen("tcp", ":8080")
    defer ln.Close()
    if err != nil {
        log.Panic(err)
    }

    for {
        // accept connections
        c, err := ln.Accept()
        if err != nil {
            log.Fatal(err)
            continue
        }
        // handle the connection
        go func(conn net.Conn) {

            /*reader := bufio.NewReader(conn)

            for {
                // read one line (ended with \n or \r\n)
                line, err := reader.ReadString('\n')
                if err != nil {
                    break
                }
                if strings.TrimSpace(line) == "" {
                    break
                }
            }
*/
            daytime := time.Now().String() + " ...Hallo\n"
            fmt.Fprintf(conn, daytime)
            conn.Close()
        }(c)
    }
}
