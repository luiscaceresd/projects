import React from "react";
//import { Link } from "react-router-dom";
import { Box, HStack, Image } from "@chakra-ui/react";

const Navbar = () => {
  return (
    <div>
    <Box
      position="fixed"
      top={0}
      left={0}
      right={0}
      translateY={0}
      transitionProperty="transform"
      transitionDuration=".3s"
      transitionTimingFunction="ease-in-out"
      backgroundColor="#fff"
      display="flex"
      alignItems="center"
      justifyContent="space-between"
      margin="0 auto"
      paddingX={8}
      paddingY={4}
    >
        <Box color="#000" maxWidth="1280px" margin="0 auto" height={60} display="grid" placeItems="center">
            <nav>
                <HStack spacing={20} >
                <Image src="./icons_assets/2/logo.png" alt="logo" width="50px"></Image>
                <a className="navLinks" href="">Home</a>
                <a className="navLinks" href="">About</a>
                <a className="navLinks" href="">Menu</a>
                <a className="navLinks" href="">Reservations</a>
                <a className="navLinks" href="">Order Online</a>
                <a className="navLinks" href="">Login</a>
                </HStack>
            </nav>
        </Box>
    </Box>
    </div>
  );
};

export default Navbar;