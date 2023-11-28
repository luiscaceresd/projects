import React from "react";
import {Box, Flex, SimpleGrid, Image} from "@chakra-ui/react";

const Footer = () => {
  return (
    <Box backgroundColor="#495E57">
      <footer>
        <Flex
          margin="0 auto"
          px={12}
          color="#fff"
          justifyContent="center"
          alignItems="center"
          maxWidth="1024px"
          height={200}
        >
            <SimpleGrid columns={5} spacing={10}>
            <Box bg='#495E57' height='50px'><Image src="my-app/icons_assets/logo.png" alt="logo"/></Box>
            <Box bg='#495E57' height='50px'></Box>
            <Box bg='#495E57' height='50px'></Box>
            <Box bg='#495E57' height='50px'><a className="footerLinks" href="">Home</a><br/><a className="footerLinks" href="">About</a><br/><a className="footerLinks" href="">Menu</a></Box>
            <Box bg='#495E57' height='50px'><a className="footerLinks" href="">Reservations</a><br/><a className="footerLinks" href="">Order Online</a><br/><a className="footerLinks" href="">Login</a></Box>
            </SimpleGrid>
        </Flex>
      </footer>
    </Box>
  );
};
export default Footer;